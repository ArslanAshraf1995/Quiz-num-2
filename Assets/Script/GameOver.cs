using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public bool gameOver = false;
    private Rigidbody playerRb;
    public Text textShow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Vector3 explosionPos = new Vector3(transform.position.x - 1, transform.position.y - 1, transform.position.z - 1);

        if (collision.gameObject.CompareTag("Wall"))
        {
            //playerRb.AddExplosionForce(10, explosionPos, 10, 0.5f, ForceMode.Impulse);
            textShow.text = "Game Over";
            gameOver = true;
        }
        
    }
}
