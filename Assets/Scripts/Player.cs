using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public PlayerState currentState;

    public PlayerIdleState idleState;

    [Header("Components")]
    public Rigidbody2D rb;
    public PlayerInput playerInput;
    public Animator anim;
    public CapsuleCollider2D playerCollider;

    [Header("Movement")]
    public float walkSpeed;
    public float runSpeed = 8;

    public int facingDirection = 1;

    //Inputs
    public Vector2 moveInput;
    public bool runPressed;
}
