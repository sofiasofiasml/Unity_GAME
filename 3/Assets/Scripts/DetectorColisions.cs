using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColisions : MonoBehaviour
{
    // When there are the colllision, the object destroyed
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); 
    }
}
