using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Access Modifier Type Name Operator Value
    private int speed = 30;
    private float turnSpeed = 60;
    
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward & back based on forwardInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate vehicle left and right based on horizontalInput
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime );
    }
}
