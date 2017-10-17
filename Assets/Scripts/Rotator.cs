using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    public float speed;
    private void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }
}
