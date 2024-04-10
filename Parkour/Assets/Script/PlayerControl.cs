using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
   private Rigidbody rd;
   public float jumpForce = 400.0f;
   public bool isOnGround;
   public bool gameOver = false;
   public ParticleSystem explosionParticl;
   public ParticleSystem dirtParticl;
   private Animator PlayerAnim;
   public AudioClip jumpSound;
   public AudioClip crushSound;
   public AudioSource playerSound;
    void Start()
    {
        PlayerAnim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody>();
        // rd.constraints = RigidbodyConstraints.FreezeRotation;
        isOnGround = true; 
        playerSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround == true){
            rd.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            PlayerAnim.SetTrigger("Jump_trig");
            isOnGround = false;
            playerSound.PlayOneShot(jumpSound, 1.2f);
            dirtParticl.Stop();
        }
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
            dirtParticl.Play();
        }else if(collision.gameObject.CompareTag("Obstacle")){
            gameOver = true;
            dirtParticl.Stop();
            explosionParticl.Play();
            PlayerAnim.SetBool("Death_b", true);
            PlayerAnim.SetInteger("DeathType_int", 1);
            PlayerAnim.SetTrigger("Jump_trig");
            playerSound.PlayOneShot(crushSound, 1.6f);
            Debug.Log("Woo, game Over!");
        }
    }
}
