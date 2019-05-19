using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfBalloons;

    public Image[] balloons;
    public Sprite fullBalloon;
    public Sprite emptyBalloon;

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
