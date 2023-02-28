using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Player : MonoBehaviour
{
    public List<CharacterBody> Forms;

    public CharacterBody CurrentForm;

    public Animator ChangeFormVFX;


    [SerializeField] private CharacterController2D CharacterController;

    [SerializeField] private Rigidbody2D Rigidbody;


    [SerializeField] private Animator Animator;

    public float BloomShift;

    public float BloomK;

    private void Start()
    {
        ChangeForm(0);
    }


    private void Update()
    {
        bool jump = Input.GetKeyDown(KeyCode.Space);
        float movement = Input.GetAxis("Horizontal") * 2;

        if (movement * movement > 0)
            Animator.SetBool("IsRunning", true);
        else
            Animator.SetBool("IsRunning", false);

        Animator.SetBool("IsJumping", !CharacterController.Grounded);

        //Debug.Log(movement);
        CharacterController.Move(movement, false, jump);


        if (Input.GetKeyDown(KeyCode.F)) ChangeForm(1);

        if (Input.GetKeyDown(KeyCode.E)) ChangeForm(0);
        if (FindObjectOfType<Volume>().profile.TryGet(out ShadowsMidtonesHighlights output))
        {
            var val =(GetComponent<Health>().CurrentHP / GetComponent<Health>().MaxHP)-1;
            output.shadows.value = new Vector4(1, 1, 1, val);
            // Debug.Log(output.shadows.value);
        }

        if (FindObjectOfType<Volume>().profile.TryGet(out Bloom output2))
        {
            output2.threshold.value = BloomK*GetComponent<Health>().CurrentHP / GetComponent<Health>().MaxHP + BloomShift;
        }
    }


    public void ChangeForm(int index)
    {
        CurrentForm.gameObject.SetActive(false);


        CurrentForm = Forms[index];

        CurrentForm.gameObject.SetActive(true);


        Animator = CurrentForm.transform.GetComponent<Animator>();

        CharacterController.CeilingCheck = CurrentForm.TopAnchor;
        CharacterController.GroundCheck = CurrentForm.BottomAnchor;

        if (CurrentForm.Flying)
        {
            Rigidbody.gravityScale = 0;
            Rigidbody.velocity = new Vector2(Rigidbody.velocity.x, 0);
            CharacterController.AirControl = true;
        }
        else
        {
            Rigidbody.gravityScale = 1;
            CharacterController.AirControl = false;
        }


        StartCoroutine(ChangeFormAnimation());
    }


    private IEnumerator ChangeFormAnimation()
    {
        ChangeFormVFX.gameObject.SetActive(true);
        ChangeFormVFX.Play("Form_change");
        yield return new WaitForSeconds(0.5f);
        ChangeFormVFX.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("test");
        if (other.CompareTag("Mirror"))
        {
            other.GetComponent<Mirror>().EndLevel();
        }
    }
}