using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public FixedJoystick joystick;
    public Rigidbody2D rb;
    public Animator animator;
    private bool facingRight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
    }
        
    void FixedUpdate()
    {
        Vector2 direction = Vector2.up * joystick.Vertical + joystick.Horizontal * Vector2.right;
        rb.MovePosition(rb.position + speed * direction * Time.fixedDeltaTime);

        animator.SetFloat("Horizontal", direction.x * -1);
        animator.SetFloat("Speed", direction.sqrMagnitude);

        if (direction.x > 0 && !facingRight || direction.x < 0 && facingRight)
        {
            facingRight = !facingRight;

            transform.Rotate(0f, 180f, 0f);
        }
    }
}
