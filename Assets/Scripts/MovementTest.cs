using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ProjectileMovement projectileMovementObject = GetComponent<ProjectileMovement>();
        projectileMovementObject.UpdatePosition();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
