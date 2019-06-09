using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text scoreText;
    public static int theScore;

    // When reset button is pressed the score resets.
    private void OnLevelWasLoaded(int level)
    {
        theScore = 0;
    }

    // Counts up the score of the rings.
    void Update()
    {       
        scoreText.GetComponent<Text>().text = "SCORE: " + theScore;
    }
}
