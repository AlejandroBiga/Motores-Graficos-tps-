using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float UpForce;
    [SerializeField] private float speed = 3f;

    
    
   
    private Rigidbody playerRb;
    
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

    

}
