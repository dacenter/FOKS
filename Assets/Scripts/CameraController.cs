using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector2 Speed;
    
    public Vector3 Shift;
[SerializeField]
    private float ShiftX;
    [SerializeField]
    [Range(0f, 20f)]
    private float ReturnTimeMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Shift.x = ShiftX * (target.position - transform.position).normalized.x;
        var newPos =  Vector2.SmoothDamp(transform.position-Shift, target.position, ref Speed, Time.fixedDeltaTime*ReturnTimeMultiplier);
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, newPos.x, 0.7f), newPos.y, -10);
    }
}
