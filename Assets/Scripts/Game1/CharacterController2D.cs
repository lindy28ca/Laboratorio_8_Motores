using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D myRBD2;
    [SerializeField] private float velocity;
    private Vector2 moveInput;

    private void Awake()
    {
        myRBD2 = GetComponent<Rigidbody2D>();
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        myRBD2.linearVelocity = new Vector2(moveInput.x * velocity, moveInput.y* velocity);
    }
}
