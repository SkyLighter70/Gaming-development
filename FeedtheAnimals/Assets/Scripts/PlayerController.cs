using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25.0f;
    public float xRange = 25.0f;
    public GameObject foodProjectile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //get input and stores it in horizontalInput
        horizontalInput = Input.GetAxis("Horizontal");
        //takes the horizontalInput and multiplies by speed and Time.deltaTime to control the speed and have it trigger once per second.
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        //block the player at -xRange
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            
        }
        //block the player at xRange
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodProjectile, transform.position, foodProjectile.transform.rotation);
        }
    }
}
