using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xRange = 10;
    private float horizontalInput;
    private float verticalInput; 
    float speed = 10.0f;
    public GameObject projectilePrefab;

    public int health = 3;
  
    private bool gameOver; 

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Lives " + health);
        Debug.Log("Score " + score);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			// Launch a projectile from the player
			Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
		}
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
     void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (health < 1)
            {
                health = 0;
                Debug.Log("Game Over!");
            }else
            {
                health -= 1;
                Destroy(collision.gameObject);
                Debug.Log("Lives " + health);
            }
               
        }
    }
 
}
