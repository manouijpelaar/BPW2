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
    float milliseconds = 0f;
    string minutesS = "";
    string secondsS = "";
    string millisecondsS = "";

    void Update()
    {
        // counts seconds up if the millisec and sec are to 100 and 59.
        if (milliseconds >= 100)
        {
            if (seconds >= 59)
            {
                minutes++;
                seconds = 0;
            }
            else if (seconds < 59)
            {
                seconds++;
            }
            milliseconds = 0;
        }

        milliseconds += Time.deltaTime * 100;
        if (minutes < 10)
        {
            minutesS = "0" + minutes;
        }
        else
        {
            minutesS = "" + minutes;
        }

        if (seconds < 10)
        {
            secondsS = "0" + seconds;
        }
        else
        {
            secondsS = "" + seconds;
        }

        if ((int)milliseconds < 10)
        {
            millisecondsS = "0" + (int) milliseconds;
        }
        else
        {
            millisecondsS = "" + (int) milliseconds;
        }

        timerText.text = (string.Format("{0}:{1}:{2}", minutesS, secondsS, millisecondsS));

        /* https://stackoverflow.com/questions/41641731/time-based-scoring-unity
        if (minutes > 1)
        {
            theScore -= 100
        }
        
        if (seconds > 30)
        {
            theScore += 50 
        }

        if (seconds < 30)
        {
            theScore += 150
        }
        */
    }
}
