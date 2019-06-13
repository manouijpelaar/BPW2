using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountUp : MonoBehaviour
{
    public Text timerText;

    // Variables for making the timer al set to the beginning of 0 and still empty.
    float minutes = 0f;
    float seconds = 0f;

    public bool levelComplete;
    public bool levelFailed;
    bool LevelWasCompleted;

    public Text TimeScoreText;
    private float timer;
    private int timeScore;

    public int maxTimeScore = 150;
    public int minTimeScore = 0;
    public int maxSeconds = 35 ;
    
    void Update()
    {
        // Counts seconds up if the millisec and sec are to 100 and 59.
        minutes = Mathf.Floor(timer / 60);
        seconds = Mathf.RoundToInt(timer % 60);

        timerText.text = (string.Format("{0:00}.{1:00}", minutes, seconds));

        timer += Time.deltaTime;
        if (levelComplete == true && LevelWasCompleted == false)
        {
            ShowScoreOnLevelComplete();

            LevelWasCompleted = true;
        }
    }

    void ShowScoreOnLevelComplete()
    {
        if (seconds < maxSeconds)
        {
            timeScore += maxTimeScore;
        }

        else
        {
            timeScore += minTimeScore;
        }

        // We only need to update the text if the score changed.
        TimeScoreText.text = "Your Score: " + (ScoreSystem.theScore + timeScore);
        Debug.Log(ScoreSystem.theScore);

        if (levelComplete == true || levelFailed == true)
        {
            // Reset the timer to 0.
            timer = 0;
        }
    }
}
