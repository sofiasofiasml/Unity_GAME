using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private float rangeXGenerator = 20f;
    private float posZGenreator = 20f;

    private float segondInitial = 2.0f;
    private float intervalGeneration = 1.5f; //seconds
    // Start is called before the first frame update
    void Start()
    {
        //empieza habiendo pasado 2 segundos y cada 1.5 segundo llama la función
        InvokeRepeating("GenerateAnimalsRandoms", segondInitial, intervalGeneration); 
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void GenerateAnimalsRandoms()
    {
        int indexAnimals = Random.Range(0, animalsPrefabs.Length);
        Vector3 positionGen = new Vector3(Random.Range(-rangeXGenerator, rangeXGenerator), 0, posZGenreator);
        Instantiate(animalsPrefabs[indexAnimals], positionGen, animalsPrefabs[indexAnimals].transform.rotation);
        
    }
}
