using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerControl : MonoBehaviour
{
    public float speed = 10.0f;
    public float horitzonalMov;
    public float rangeX = 21.0f;
    public GameObject pryectilPrefab;
    public GameObject proyectilBoon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when you click space the food
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 posProyectil = new Vector3(transform.position.x, pryectilPrefab.transform.position.y, transform.position.z); 
            Instantiate(pryectilPrefab, posProyectil, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Vector3 posProyectilBoon = new Vector3(transform.position.x, proyectilBoon.transform.position.y, transform.position.z);
            Instantiate(proyectilBoon, posProyectilBoon, transform.rotation);
        }
        //limits in the x-axis
        if (transform.position.x < -rangeX)
        {
            transform.position = new Vector3(-rangeX, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rangeX)
        {
            transform.position = new Vector3(rangeX, transform.position.y, transform.position.z);
        }
        horitzonalMov = Input.GetAxis("Horizontal");

        //move the gamer in the x-axis
        transform.Translate(Vector3.right * Time.deltaTime * horitzonalMov * speed); 


    }
}
