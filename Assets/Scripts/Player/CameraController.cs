using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector2 Speed;

    public Vector3 Shift;

    [SerializeField] private float ShiftX;

    [SerializeField] [Range(0f, 20f)] private float ReturnTimeMultiplier;

    private void FixedUpdate()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        Shift.x = ShiftX * (target.position - transform.position).normalized.x;
        Vector2 newPos = Vector2.SmoothDamp(transform.position - Shift, target.position, ref Speed,
            Time.fixedDeltaTime * ReturnTimeMultiplier);
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, newPos.x, 0.7f), newPos.y, -10);
    }
}