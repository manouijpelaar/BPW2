using UnityEngine;

public class Credits : MonoBehaviour
{

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    
}
