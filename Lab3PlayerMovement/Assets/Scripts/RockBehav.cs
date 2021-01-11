using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehav : MonoBehaviour
{
    public Rigidbody rockRb;
    public GameObject Sun;


    private float speed = 2.0f;
    //variables
    
    // Start is called before the first frame update
    void Start()
    {
        
        Sun = GameObject.Find("Sun");
    }

    // Update is called once per frame
    void Update()
    {
        //Need to get it so it spawns facing the orgin
        rockRb.transform.position = transform.position += Vector3.forward * Time.deltaTime * speed;
    }
}
