using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] private float UpForce;
    [SerializeField] private float speed = 3f;


    public int ItemsCollected;
    
    private Rigidbody playerRb;

    public Text score;
    void Start()
    {


        playerRb = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate( horizontalInput, 0f, verticalInput);

        Input.GetAxis("Horizontal");
        Input.GetAxis("Vertical");
        


        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * UpForce);
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("item"))
        {
            Destroy(collision.gameObject);

            // ++ = ItemsCollected = itemsCollected + 1
            ItemsCollected++;

            score.text = ItemsCollected.ToString();
        }
    }

}
