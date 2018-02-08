using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Camera gameCamera = GetComponent<Camera>();
        Ray aimRay = gameCamera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(aimRay.origin, aimRay.direction, Color.red);
    }
}
