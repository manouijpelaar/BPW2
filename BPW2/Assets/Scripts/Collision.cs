using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Variables to connect gameobjects to this code
    public GameObject player;
    public GameObject spawnPoint;
    public Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        //transform = player.gameObject.GetComponent<Transform>();
    }

    void OnTriggerEnter(Collider col)
    {   // if player hits the tag
        if (col.gameObject.tag == "Fail")
        {
            Respawn();
        }
    }

    // Respawn the player to a determined position
    void Respawn()
    {
        this.transform.position = spawnPoint.transform.position;
    }
}
