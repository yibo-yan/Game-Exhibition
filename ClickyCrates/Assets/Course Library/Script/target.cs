using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class target : MonoBehaviour
{
    // variables to be applied
    private Rigidbody targetRb;
    private float minSpeed = 14;
    private float maxSpeed = 18;
    private float torqueRange = 10;
    private float xRange = 4;
    private float yVal = -6;
    public int scoreTarget;
    private GameManager gameManager;
    public ParticleSystem particleEffect;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(getForce(), ForceMode.Impulse);
        targetRb.AddTorque(randomTorque(), randomTorque(), randomTorque(), ForceMode.Impulse);
        transform.position = randomPos();
        // conncect to the GameManger file
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // if you clicking on the gameObject, it will destroy it
    private void OnMouseDown(){
        gameManager.updateScore(scoreTarget);
        Destroy(gameObject);
        Instantiate(particleEffect, transform.position, transform.rotation);
    }
    // if the gameObject collide with the sensor, it will be destroyed
    private void OnTriggerEnter(Collider Other){
        Destroy(gameObject);
        if(!gameObject.CompareTag("Bad")){
            gameManager.gameOver();
        }
    }
    Vector3 getForce(){
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    float randomTorque(){
        return Random.Range(-torqueRange, torqueRange);
    }
    Vector3 randomPos(){
        return new Vector3(Random.Range(-xRange, xRange), yVal);
    }


}
