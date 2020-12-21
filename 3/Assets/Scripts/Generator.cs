using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private float rangeXGenerator = 20f;
    private float posZGenreator = 20f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int indexAnimals = Random.Range(0, animalsPrefabs.Length);
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 positionGen = new Vector3(Random.Range(-rangeXGenerator, rangeXGenerator),0, posZGenreator);
            Instantiate(animalsPrefabs[indexAnimals], positionGen , animalsPrefabs[indexAnimals].transform.rotation); 
        }
    }
}
