using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour
{
    // Start is called before the first frame update
    public float upperBound = 30;
    public float lowerBound = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > upperBound){
            Destroy(gameObject);
        }
        if(transform.position.z < lowerBound){
            Debug.Log("Game OVer");
            Destroy(gameObject);
        }
    }
}
