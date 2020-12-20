using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed = 2.0f;

    public float jumpHeight = 1.0f;

    public float gravityValue = -9.81f;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    private Player playerInput;

    private void Awake()
    {
        playerInput = new Player();
    }

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movementInput = playerInput.PlayerMain.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (playerInput.PlayerMain.Jump.triggered && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
