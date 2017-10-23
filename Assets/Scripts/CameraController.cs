using UnityEngine;

public class CameraController : MonoBehaviour {
    // Spieler
    public GameObject player;
    // Kamera
    public new GameObject camera;
    // Position
    private Vector3 pos;
    private void Start()
    {
        // Position = Camera Position - Spieler Position
        pos = camera.transform.position - player.transform.position;
    }
    private void LateUpdate()
    {
        // Kamera Position = Spieler Position + Position
        camera.transform.position = player.transform.position + pos;
    }
}