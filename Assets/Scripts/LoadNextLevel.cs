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
        if (ScoreManager.skullsCollected == true)
        {
            SceneManager.LoadScene(nextSceneName);
        }

    }
}