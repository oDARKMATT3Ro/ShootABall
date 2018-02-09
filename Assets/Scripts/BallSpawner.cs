using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject prefab;
    public PlayerAim aimComponent;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray aimRay = aimComponent.GetAimRay();
            Quaternion aimRotation = Quaternion.LookRotation(aimRay.direction);
            Instantiate(prefab, transform.position, aimRotation);
        }
	}
}
