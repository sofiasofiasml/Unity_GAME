using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGamer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //changing the position of the van on the z-axis
        transform.Translate(Vector3.forward * Time.deltaTime * 15); 
        
    }
}
