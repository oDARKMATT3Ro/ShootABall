using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

    public Vector3 newPosition;

	// Use this for initialization
	void Start () {

	}

    public void UpdatePosition()
    {
        Transform t = GetComponent<Transform>();
        t.position = newPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
