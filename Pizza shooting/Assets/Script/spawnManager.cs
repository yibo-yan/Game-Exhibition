using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefebs;
    private float startDelay = 2.0f;
    private float intervalDelay = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimal", startDelay, intervalDelay);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void spawnAnimal(){
        int randomNum = Random.Range(0, animalPrefebs.Length);
        Instantiate(animalPrefebs[randomNum], new Vector3(Random.Range(-10, 10), 0, 30), animalPrefebs[randomNum].transform.rotation);
    }
}
