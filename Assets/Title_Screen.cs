using UnityEngine;
using UnityEngine.SceneManagement;

public class Example : MonoBehaviour
{
    // Detects if any key has been pressed.

    void Update()
    {
        if (Input.anyKey)
        {
            Debug.Log("A key or mouse click has been detected");
            
        }
    }
}