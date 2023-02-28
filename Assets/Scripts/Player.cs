using System.Collections;
using System.Collections.Generic;
using Delight;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Animator = UnityEngine.Animator;

public class Player : MonoBehaviour
{
    public bool RecieveInput;
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
        if (RecieveInput)
        {
            bool jump = Input.GetKeyDown(KeyCode.Space);
            float movement = Input.GetAxis("Horizontal") * 2;

            Animator.SetBool("IsRunning", movement * movement > 0);


            //Debug.Log(movement);
            CharacterController.Move(movement, false, jump);


            if (Input.GetKeyDown(KeyCode.F)) ChangeForm(1);

            if (Input.GetKeyDown(KeyCode.E)) ChangeForm(0);
        }

        Animator.SetBool("IsJumping", !CharacterController.Grounded);

        if (FindObjectOfType<Volume>().profile.TryGet(out ShadowsMidtonesHighlights output))
        {
            float val = GetComponent<Health>().CurrentHP / GetComponent<Health>().MaxHP - 1;
            output.shadows.value = new Vector4(1, 1, 1, val);
            // Debug.Log(output.shadows.value);
        }

        if (FindObjectOfType<Volume>().profile.TryGet(out Bloom output2))
            output2.threshold.value =
                BloomK * GetComponent<Health>().CurrentHP / GetComponent<Health>().MaxHP + BloomShift;

        if (transform.position.x < -2)
        {
            MainGameView.CurrentText = "АЙ, ПУСТИТЕ";
            MainGameView.IsShow = true; 
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("test");
        if (other.CompareTag("Mirror")) other.GetComponent<Mirror>().EndLevel();
        
        if(other.CompareTag("StoryTrigger")) Story.Instance.OnTrigger(other.gameObject.name);
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
}