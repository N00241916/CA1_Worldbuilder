using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [Tooltip("Name of the scene to load. It must be listed in Build Settings.")]
    [SerializeField] string nextSceneName = "level_2";

    public void LoadNextLevel()
    {
          
    }

    void OnTriggerEnter(Collider other)
    {
        if (nextSceneName == "level_2")
        {
            if (ScoreManager.skullsCollected == true)
            {
                SceneManager.LoadScene(nextSceneName);
            }
            else
            {
                SkeletextScript.textbox.SetActive(true);

            }
        }
        else if (nextSceneName == "level_1")
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        SkeletextScript.textbox.SetActive(false);
    }
}