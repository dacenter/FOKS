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
        
        if ((transform.position - CurrentTarget.position).magnitude<0.1f)
        {
            CurrentTarget = CurrentTarget == FirstPoint ? SecondPoint : FirstPoint;


            
        }
        var targetPosition = CurrentTarget.position;
        transform.position = Vector3.SmoothDamp(transform.position,targetPosition
            , ref speed, Mathf.Max(500f * Time.deltaTime, 0.1f));
    }
}