using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winTrigger : MonoBehaviour
{
    public GameObject player;
    //public GameObject completeLevelScreen;
    //public TargetVolgorde targetManager;

    void OnTriggerEnter(Collider win)
    {   // when player collides with winscene, level complete
        if (win.gameObject.tag == "Player")
        {
            win.gameObject.GetComponentInParent<Rigidbody>().isKinematic = true;
            SceneManager.LoadScene(6);
            Debug.Log("You Win!");
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
        }
    }
}
