using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnObj;
    public GameObject backSpawn;
    public PlayerControl PlayerControlScript;
    void Start()
    {
        PlayerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
        InvokeRepeating("spawner", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawner(){
        if(PlayerControlScript.gameOver == false){
             Instantiate(spawnObj, new Vector3(40, 0, 0), spawnObj.transform.rotation);
        }
       
    }
}
