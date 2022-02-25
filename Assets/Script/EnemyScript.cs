using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject playerObject;
    private GameObject wallObject;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        
       playerObject = GameObject.Find("Player");
        
        wallObject = GameObject.Find("Walls");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (playerObject.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

    }
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("Wall"))
		{
            Destroy(gameObject);
		}

	}

}
