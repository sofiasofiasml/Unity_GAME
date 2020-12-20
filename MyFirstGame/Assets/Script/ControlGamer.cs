using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGamer : MonoBehaviour
{
    private float velocity = 20.0f; //if this variable is public, you can change in unity program 
    private float velocityTurn = 25.0f; //turn velocity
    private float controlHorizontal;
    private float controlVertical; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //read de input the diferents axis
        controlHorizontal = Input.GetAxis("Horizontal");
        controlVertical = Input.GetAxis("Vertical"); 

        //changing the position of the van on the z-axis
        transform.Translate(Vector3.forward * Time.deltaTime * velocity * controlVertical);
        
        //move rigth and left
        //transform.Translate(Vector3.right * Time.deltaTime * velocityTurn * controlHorizontal); 
        
        //roate in the y-axis
        transform.Rotate(Vector3.up, Time.deltaTime * velocityTurn * controlHorizontal); 
    }
}
