using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour {

    public float RotationSpeed;
    private bool isRotating;

	// Use this for initialization
	void Start () {
        isRotating = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isRotating)
        {
            transform.Rotate(Vector3.forward, RotationSpeed);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isRotating = false;
    }
}
