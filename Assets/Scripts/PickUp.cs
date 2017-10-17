using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {
    private int points;
    public Text score;
    public Button again;
    private void Start()
    {
        again.gameObject.SetActive(false);   
    }
    private void Update()
    {
        score.text = "Score: " + points;
        if (points >= 6)
            again.gameObject.SetActive(true);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            points++;
        }
    }
}
