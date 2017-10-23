using UnityEngine;

public class Rotator : MonoBehaviour {
    // Geschwindigkeit
    public float speed;
    private void Update()
    {
        // Rotiere das Objekt
        gameObject.transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }
}