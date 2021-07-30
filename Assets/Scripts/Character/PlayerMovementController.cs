using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public Transform forwardTransform;
    CharacterController characterController;

    float yVelocity;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {
            yVelocity = -5.0f;
        }
        else
        {
            yVelocity -= Physics.gravity.magnitude * Time.deltaTime;
        }
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 horizontalMovement = Quaternion.Euler(0.0f, forwardTransform.eulerAngles.y, 0.0f) * new Vector3(input.x, 0.0f, input.y) * movementSpeed * Time.deltaTime;
        Vector3 movement = horizontalMovement + Vector3.up * yVelocity * Time.deltaTime;
        characterController.Move(movement);
    }
}
