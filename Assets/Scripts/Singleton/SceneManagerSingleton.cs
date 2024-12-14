using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerSingleton : MonoBehaviour
{
    // Static instance of the SceneManagerSingleton
    public static SceneManagerSingleton Instance { get; private set; }

    private void Awake()
    {
        // Ensure only one instance of the SceneManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicates
        }
    }

    /// <summary>
    /// Load a scene by name.
    /// </summary>
    public void LoadScene(string sceneName)
    {
        Debug.Log($"Loading scene: {sceneName}");
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// Reload the current scene.
    /// </summary>
    public void ReloadScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        Debug.Log($"Reloading scene: {currentSceneName}");
        SceneManager.LoadScene(currentSceneName);
    }

    /// <summary>
    /// Load the next scene by build index.
    /// </summary>
    public void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            Debug.Log($"Loading next scene: Index {nextSceneIndex}");
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("No more scenes in build settings.");
        }
    }
}
