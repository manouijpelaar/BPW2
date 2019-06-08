using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text scoreText;
    public static int theScore;

    private void OnLevelWasLoaded(int level)
    {
        theScore = 0;
    }

    void Update()
    {       
        scoreText.GetComponent<Text>().text = "SCORE: " + theScore;
    }
}
