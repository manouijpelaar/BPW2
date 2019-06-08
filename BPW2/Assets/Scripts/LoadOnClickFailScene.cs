using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnClickFailScene : MonoBehaviour
{

    // Loads scene if application is used (or pressed when set on a button).
    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
    }
}
