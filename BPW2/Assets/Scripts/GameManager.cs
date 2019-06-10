using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static GameManager manager;
    //public Collision collider;
    public static int levelIndex;
    public Text CountDown;

    void Start()
    {
        StartCoroutine(Countdown(3));
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
        //GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>().enable();
    }

    // Singleton gamemanager for every script.
    public static GameManager Manager
    {
        get
        {
            if (manager == null)
                manager = FindObjectOfType<GameManager>();

            return manager;
        }
    }

    IEnumerator Countdown(int seconds)
    {
        int count = seconds;

        while (count > 0)
        {

            // display something...
            yield return new WaitForSeconds(1);
            count--;
            CountDown.text = count.ToString();
        }

        // count down is finished...
        StartGame();
    }

    void StartGame()
    {
        
    }
}
