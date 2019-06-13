using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject levelComplete;
    public GameObject winUI;

    void OnTriggerEnter(Collider win)
    {   // when player collides with winscene, level complete and menu music plays
        if (win.gameObject.tag == "Player")
        {
            win.gameObject.GetComponentInParent<Rigidbody>().isKinematic = true;
            player.GetComponent<CharacterController>().enabled = false;
            player.GetComponent<AudioSource>().Stop();
            winUI.SetActive(true);
            Debug.Log("You Win!");
            GameObject musicObject = GameObject.FindGameObjectWithTag("Music");
            if (musicObject != null)
            {
                musicObject.GetComponent<MusicClass>().PlayMusic();
            }

            levelComplete.GetComponent<TimerCountUp>().levelComplete = true;
        }
    }
}
