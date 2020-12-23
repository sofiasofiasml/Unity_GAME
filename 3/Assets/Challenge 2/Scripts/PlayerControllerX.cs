using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float TimepoEspera = 1;
    private float TimepoSiguienteDisparo = 0; 
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > TimepoSiguienteDisparo)
        {
            TimepoSiguienteDisparo = Time.time + TimepoEspera; 
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
