using UnityEngine;
using UnityEngine.SceneManagement;

public class Title: MonoBehaviour
{
    // Detects if any key has been pressed.

    void Update()
    {

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        else if (Input.anyKey)
        {
            Debug.Log("A key or mouse click has been detected");
            SceneManager.LoadScene(1);
        }
    }
}