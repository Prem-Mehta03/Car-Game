using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour

    // up/down and w/s keys should move the camera forward and backward.
{   
    public Transform Camera_target;

    // Update is called once per frame
    void LateUpdate()
    {
       transform.position = new Vector3(Camera_target.position.x,Camera_target.position.y,-10f);
    }

}
