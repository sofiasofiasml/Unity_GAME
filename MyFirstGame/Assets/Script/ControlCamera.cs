using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    private Vector3 desplace = new Vector3(4, 11, -14);
    public GameObject Van; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Van.transform.position + desplace; 
    }
}
