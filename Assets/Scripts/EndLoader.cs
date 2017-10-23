using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLoader : MonoBehaviour {
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
