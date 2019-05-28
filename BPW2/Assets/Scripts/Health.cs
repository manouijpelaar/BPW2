using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfBalloons;

    public Image[] balloons;
    public Sprite fullBalloon;
    public Sprite emptyBalloon;

    public void TakeDamage(int amount)
    {
        health -= amount;

        // when player has no health, level failed
        if (health == 0 && gameObject.tag == "Player")
        {
            gameObject.GetComponentInParent<Rigidbody>().isKinematic = true;
            SceneManager.LoadScene(7);
            Debug.Log("You Lose!");
        }
    }

    void Update()
    {
        if(health > numOfBalloons)
        {
            health = numOfBalloons;
        }

        for (int i = 0; i < balloons.Length; i++)
        {
            if(i < health)
            {
                balloons[i].sprite = fullBalloon;
            }

            else
            {
                balloons[i].sprite = emptyBalloon;
            }

            if(i < numOfBalloons)
            {
                balloons[i].enabled = true;
            }

            else
            {
                balloons[i].enabled = false;
            }
        }
    }
}
