using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Variables to connect gameobjects to this code
    public GameObject player;
    public GameObject spawnPoint;
    public Transform transform;
    public Health life;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {   // if player hits the tag
        if (col.gameObject.tag == "Fail")
        {
            Respawn();
            life.TakeDamage(1);
        }
    }

    // Respawn the player to a determined position
    void Respawn()
    {
        this.transform.position = spawnPoint.transform.position;
    }
}
