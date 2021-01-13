using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehav : MonoBehaviour
{
    public Rigidbody rockRb;
    public GameObject Sun;
    //spawnVar is the variable to accsess the script "spawnManager"
    public SpawnManager spawnVar;

    private float speed = 2.0f;
    //variables
    
    // Start is called before the first frame update
    void Start()
    {
        spawnVar = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        Sun = GameObject.Find("Sun");
    }

    // Update is called once per frame
    void Update()
    {
        //Need to get it so it spawns facing the orgin
        Vector3 lookDirection = (Sun.transform.position - transform.position).normalized;
        rockRb.AddForce(lookDirection * speed);

        RockBoundsCheck();
        //TouchingSun();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy this object
        Destroy(gameObject);
        spawnVar.gameOver = "T";

        
    }

    public void RockBoundsCheck()
    {
        if (transform.position.x < -15)
        {
            
            Destroy(gameObject);
            spawnVar.spawnInterval -= .01f;
            spawnVar.score += 1.0f;
        }
        if (transform.position.x > 15)
        {
            
            Destroy(gameObject);
            spawnVar.spawnInterval -= .01f;
            spawnVar.score += 1.0f;
        }
        if (transform.position.z < -15)
        {
            
            Destroy(gameObject);
            spawnVar.spawnInterval -= .01f;
            spawnVar.score += 1.0f;
        }
        if (transform.position.z > 15)
        {
            
            Destroy(gameObject);
            spawnVar.spawnInterval -= .01f;
            spawnVar.score += 1.0f;
        }
    }
}
