using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour {

    public Ray GetAimRay()
    {
        Camera gameCamera = GetComponent<Camera>();
        Ray aimRay = gameCamera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(aimRay.origin, aimRay.direction, Color.red);
        return aimRay;
    }
}
