using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGamer : MonoBehaviour
{
    public float velocity = 20.0f; //if this variable is public, you can change in unity program 
    public float velocityTurn = 5;
    public float controlHorizontal;
    public float controlVertical; 
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
        transform.Translate(Vector3.right * Time.deltaTime * velocityTurn * controlHorizontal); 
    }
}
