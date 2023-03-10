using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float JumpForce = 400f; // Amount of force added when the player jumps.

    [Range(0, .3f)] [SerializeField] private float MovementSmoothing = .05f; // How much to smooth out the movement
    [SerializeField] public bool AirControl = false; // Whether or not a player can steer while jumping;
    [SerializeField] private LayerMask WhatIsGround; // A mask determining what is ground to the character
    [SerializeField] public Transform GroundCheck; // A position marking where to check if the player is grounded.
    [SerializeField] public Transform CeilingCheck; // A position marking where to check for ceilings
    [SerializeField] private float GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
    public bool Grounded; // Whether or not the player is grounded.
    const float CeilingRadius = .2f; // Radius of the overlap circle to determine if the player can stand up
    private Rigidbody2D Rigidbody2D;
    private bool FacingRight = true; // For determining which way the player is currently facing.
    private Vector3 Velocity = Vector3.zero;

    [Header("Events")] [Space] public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool>
    {
    }


    public float MaxSpeed;

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();

        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();
    }

    public void Stop()
    {
        Rigidbody2D.velocity = new Vector2(0, Rigidbody2D.velocity.y);
    }


    private void FixedUpdate()
    {
        bool wasGrounded = Grounded;
        Grounded = false;

        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        // This can be done using layers instead but Sample Assets will not overwrite your project settings.
        var colliders = Physics2D.OverlapCircleAll(GroundCheck.position, GroundedRadius, WhatIsGround);
        //Debug.Log(colliders.Length);
        foreach (Collider2D col in colliders)
        {
            if (col.gameObject == gameObject) continue;

            Grounded = true;
            if (!wasGrounded)
                OnLandEvent.Invoke();
        }
    }


    public void Move(float move, bool jump)
    {
        //only control the player if grounded or airControl is turned on
        if (Grounded || AirControl)
        {
            // Move the character by finding the target velocity
            Vector3 targetVelocity = new Vector2(move * MaxSpeed, Rigidbody2D.velocity.y);
            // And then smoothing it out and applying it to the character
            Rigidbody2D.velocity =
                Vector3.SmoothDamp(Rigidbody2D.velocity, targetVelocity, ref Velocity, MovementSmoothing);

            switch (move)
            {
                // If the input is moving the player right and the player is facing left...
                case > 0 when !FacingRight:
                // Otherwise if the input is moving the player left and the player is facing right...
                // ... flip the player.
                case < 0 when FacingRight:
                    // ... flip the player.
                    Flip();
                    break;
            }
        }

        // If the player should jump...
        if (Grounded && jump)
        {
            // Add a vertical force to the player.
            Grounded = false;
            Rigidbody2D.AddForce(new Vector2(0f, JumpForce));
        }
    }


    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        FacingRight = !FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}