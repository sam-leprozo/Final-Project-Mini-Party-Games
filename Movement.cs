using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public Rigidbody2D rb; 
    public Animator animator; 

    private Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // Left (-1) or Right (1)
        movement.y = Input.GetAxisRaw("Vertical");   // Down (-1) or Up (1)

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude); // Magnitude of movement (0 when idle)
    }


    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
