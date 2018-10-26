using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieCannon : MonoBehaviour {

    public GameObject CookiePrefab;
    public float BlastForce;
    public Transform SpawnPoint;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var axis = Input.GetAxis("Horizontal");
        gameObject.transform.Rotate(Vector3.forward, axis * 1.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var cookie = Instantiate(CookiePrefab, SpawnPoint.position, Quaternion.identity);
            var rb = cookie.GetComponent<Rigidbody2D>();
            Vector3 jitter = new Vector3() { x = Random.Range(-0.5f, 0.5f), y = Random.Range(-0.5f, 0.5f) };
            Vector3 direction = Vector3.Normalize(SpawnPoint.position - transform.position + jitter );
            rb.AddForce(direction*BlastForce);
        }
	}


}
