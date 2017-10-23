using UnityEngine;
using UnityEngine.SceneManagement;

public class BonusLoader : MonoBehaviour {
    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            LoadBonus(sceneName);
    }
    private void LoadBonus(string other)
    {
        SceneManager.LoadScene(other);
    }
}
