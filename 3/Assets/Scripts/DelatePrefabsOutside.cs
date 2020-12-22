using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelatePrefabsOutside : MonoBehaviour
{
    float limitSup = 30;
    float limitInf = -10; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limitSup)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < limitInf)
        {
            Debug.Log("Fin de Partida!");
            Destroy(gameObject);
        }
    }
}
