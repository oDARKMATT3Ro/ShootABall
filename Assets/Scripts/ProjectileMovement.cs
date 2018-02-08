using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

    public float speed = 5;

	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update()
    {
        Vector3 positionDelta = new Vector3(0, 0, speed * Time.deltaTime);
        transform.position = transform.position + positionDelta;
    }
}
