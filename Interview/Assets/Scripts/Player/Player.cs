using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private PlayerInput playerInput;

    [Header("Movement Settings")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private int facingDirection = 1;

    [Header("Inputs")]
    private Vector2 moveInput;

    [Header("GroundCheckSettings")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundRadius;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] private bool isGrounded;

    private void Update()
    {
        CheckGrounded();
        Flip();
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        float targetSpeed = moveInput.x * speed * Time.deltaTime;
        rb.linearVelocity = new Vector2(targetSpeed, rb.linearVelocity.y);
    }

    void CheckGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);
    }

    void Flip()
    {
        if(moveInput.x > 0.1f)
        {
            facingDirection = 1;
        }
        if(moveInput.x < -0.1f)
        {
            facingDirection = -1;
        }
        transform.localScale = new Vector3(facingDirection, 1, 1);
    }
}
