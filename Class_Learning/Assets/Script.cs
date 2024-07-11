using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] private Transform _target;

    //private CharacterController controller;
    // private Vector3 playerVelocity;
    // private bool playerGrounded;
    // private float playerSpeed = 2.0f;
    // private float jumpSpeed = 1.0f;

    [SerializeField]private float sensitivityX = 5F;
    [SerializeField]private float sensitivityY = 5F;
    //[SerializeField]private float minimumX = -360F;
    //[SerializeField]private float maximumX = 360F;
    [SerializeField]private float minimumY = -60F;
    [SerializeField]private float maximumY = 60F;

    private float rotationY = 0F;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        // Apply the rotation using quaternions
        transform.localRotation = Quaternion.Euler(-rotationY, rotationX, 0);













        //Vector3 relative = transform.InverseTransformPoint(target.position);
        //float angle = Mathf.Atan2(relative.x, relative.z) * Mathf.Rad2Deg;
        //transform.Rotate(0, angle, 0);


        //float vaxis = Mathf.Atan2(verticalAxis, horizontalAxis);
        //float haxis = Mathf.Atan2(horizontalAxis, verticalAxis);
        //transform.position = new Vector3(10, 5, 6);
        //transform.LookAt(_target);
    }
}
