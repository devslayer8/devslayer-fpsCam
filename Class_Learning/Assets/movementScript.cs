using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    [SerializeField]private CharacterController controller;
    [SerializeField]private Vector3 playerVelocity;
    [SerializeField]private bool playerGrounded;
    [SerializeField]private float playerSpeed = 5f;
    [SerializeField]private float jumpHeight = 5f;
    [SerializeField]private float gravityValue = -9.81f;
    




    // Start is called before the first frame update
    void Start()
    {

        controller = gameObject.AddComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        playerGrounded = controller.isGrounded;
        if(playerGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && playerGrounded)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);











    }
}
