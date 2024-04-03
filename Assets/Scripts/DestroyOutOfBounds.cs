using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 19;
	private float lowerBound = -16;
    PlayerController player;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
		{
			Destroy(gameObject);
		} else if (transform.position.z < lowerBound)
		{
            
                Destroy(gameObject); 
            if (player.health < 1)
            {
                player.health = 0;
                Debug.Log("Game Over!");
            }else
            {
                player.health -= 1;
                Destroy(gameObject);
                Debug.Log("Lives " + player.health);
            }
        }
            
            
	}
}

