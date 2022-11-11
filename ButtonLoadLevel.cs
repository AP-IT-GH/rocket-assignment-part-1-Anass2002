using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadLevel : MonoBehaviour
{
    public string resetLevelToLoad;

    public void LoadLevel()
    {
        SceneManager.LoadScene(resetLevelToLoad);
    }
}
