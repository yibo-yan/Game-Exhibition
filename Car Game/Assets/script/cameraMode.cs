using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMode : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 8, -16);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
