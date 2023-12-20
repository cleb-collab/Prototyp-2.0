using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xRange = 10;
    private float horizontalInput;
    private float forwardInput;
    float speed = 10.0f;
     public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;
    AudioSource playerAudio; 
    public AudioClip explodeSound;
    private bool gameOver; 

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    }
 private void OnCollisionEnter(Collision other)
 {
    if (other.gameObject.CompareTag("BadSnack"))
    {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Destroy(other.gameObject);
        }
 }

  

}
