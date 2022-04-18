using UnityEngine.SceneManagement;

public class LevelManager
{
    public void LoadScene(string name)
    {
        SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
    }

    public void UnloadScene(string name)
    {
        SceneManager.UnloadSceneAsync(name, UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
}