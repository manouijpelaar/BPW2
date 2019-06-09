using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterController : MonoBehaviour {

    // Variables for moving speed and upwards speed.
    public float speed = 10.0f;
    public float upwards = 8.0f;
    public GameObject fire;
    public AudioSource fireSound;

    void Start()
    {
        GameManager.levelIndex = SceneManager.GetActiveScene().buildIndex;
        // The cursor will not be visable with CursorLockMode
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Sets vertical and horizontal axis equal to the WASD keys.
        float UpDown = Input.GetAxis("Vertical") * speed + 3;
        float LeftRight = Input.GetAxis("Horizontal") * speed;
        UpDown *= Time.deltaTime;
        LeftRight *= Time.deltaTime;

        transform.Translate(LeftRight, 0, UpDown);

        // with escape the cursor can be shown again.
        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

        // Sets space key equal to an upwards force.
        if (Input.GetKey("space"))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * upwards);
        }

        // fire in airballoon plays and stops when space button is or was pressed.
        if (Input.GetKeyDown("space"))
        {
            this.GetComponentInChildren<ParticleSystem>().Play();
            fireSound.Play();
        }

        if (Input.GetKeyUp("space"))
        {
            this.GetComponentInChildren<ParticleSystem>().Stop();
        }
    }
}
