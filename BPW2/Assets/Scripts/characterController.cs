using System.Collections;
using UnityEngine;

public class characterController : MonoBehaviour {

    // Variables for moving speed and upwards speed.
    public float speed = 10.0f;
    public float upwards = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        // The cursor will not be visable with CursorLockMode
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Sets vertical and horizontal axis equal to the WASD keys.
        float UpDown = Input.GetAxis("Vertical") * speed;
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
    }
}
