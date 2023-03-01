using System;
using UnityEngine;

public class CutsceneOwl : MonoBehaviour
{
    public Transform FirstPoint;

    public Transform SecondPoint;

    public Transform CurrentTarget;

    private Vector3 speed;

    private void Start()
    {
        CurrentTarget = FirstPoint;
    }

    private void Update()
    {
        
        if ((transform.position - CurrentTarget.position).magnitude<1f)
        {
            CurrentTarget = SecondPoint;


            
        }
        
        
        
        GetComponent<CharacterController2D>().Move((CurrentTarget.position-transform.position).normalized.x,false);


        if (GetComponent<Health>().CurrentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}