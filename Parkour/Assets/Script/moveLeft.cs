using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    public float speed = 20.0f;
    private PlayerControl PlayerControlScript;
    // Start is called before the first frame update
    void Start()
    {
        PlayerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerControlScript.gameOver == false){
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
        if(transform.position.x < -15 && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
