using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private new Rigidbody rigidbody;
    public float speed = 50;
    private void Start()
    {
        rigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }
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
}
