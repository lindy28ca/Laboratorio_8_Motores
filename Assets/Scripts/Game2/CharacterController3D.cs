using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController3D : MonoBehaviour
{
    private Rigidbody myRB;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private Vector2 moveInput;
    private bool isJumping;
    private bool isGrounded;

    [SerializeField] private float groundDistance;
    [SerializeField] private LayerMask groundMask;

    private void Awake()
    {
        myRB = GetComponent<Rigidbody>();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded)
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, Vector2.down, groundDistance, groundMask);
        Vector3 movement = new Vector3(moveInput.x, 0, moveInput.y) * speed;
        myRB.linearVelocity= new Vector3(movement.x, myRB.linearVelocity.y, movement.z);
        if (isJumping)
        {
            myRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = false;
        }
    }
    public void ApplyPhysics(InputAction.CallbackContext context)
    {

    }
}
