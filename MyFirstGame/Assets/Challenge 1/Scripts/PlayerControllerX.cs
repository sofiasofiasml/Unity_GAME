using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
     float speed = 20.0f;
     float rotationSpeed = 20.0f;
     float verticalInput;
     float horizontalInput;
     float RunInput;
    public GameObject helice;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        RunInput = Input.GetAxis("Fire1");

        //move the plane in the y-axis 
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed * RunInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horizontalInput);

        //move helice when plane is moving
        helice.transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed * RunInput * 1000); 
    }
}
