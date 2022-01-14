using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartButton()
    {
        SceneManager.LoadScene("level1");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
