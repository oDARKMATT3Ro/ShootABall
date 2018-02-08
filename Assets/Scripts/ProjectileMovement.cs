using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

    public float force = 5;

	// Use this for initialization
	void Start () {

	}

    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 0, force));
    }
}
