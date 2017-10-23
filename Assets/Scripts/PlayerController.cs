using UnityEngine;

public class PlayerController : MonoBehaviour {
    // Spieler Objekt
    private GameObject player;
    // Geschwindigkeit
    public float speed = 50;
    // Rigidbody
    private new Rigidbody rigidbody;
    private void Start()
    {
        // Das Spieler Objekt ist das Objekt mit dem Player-Tag
        player = GameObject.FindGameObjectWithTag("Player");
        // Nimm die Rigidbody Komponente des Spielers
        rigidbody = player.GetComponent<Rigidbody>();
    }

    // Button Steuerung
    public void BottomButton()
    {
        rigidbody.AddForce(new Vector3(0, 0, -1) * speed * Time.deltaTime);
    }
    public void UpButton()
    {
        rigidbody.AddForce(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }
    public void LeftButton()
    {
        rigidbody.AddForce(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
    }
    public void RightButton()
    {
        rigidbody.AddForce(new Vector3(1, 0, 0) * speed * Time.deltaTime);
    }
    private void Update()
    {
        // Tastatur Steuerung
        if (Input.GetKey(KeyCode.S))
            rigidbody.AddForce(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            rigidbody.AddForce(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            rigidbody.AddForce(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            rigidbody.AddForce(new Vector3(1, 0, 0) * speed * Time.deltaTime);
    }
}