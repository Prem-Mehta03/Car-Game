using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Controller : MonoBehaviour
{
    // left/right keys and a/d keys should rotate the car.
    // up/down and w/s keys should move the car forward and backward.
    public float rotation_speed, move_speed,Boost_Multiplier;
    public Transform car_transform;

    private void Start()
    {
        car_transform.position = new Vector3(-1.9f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_movement = Input.GetAxis("Horizontal");
        float vertical_movement = Input.GetAxis("Vertical");

        

        if(Math.Abs(horizontal_movement) > 0.01f)
        {
            car_transform.Rotate(0f,0f,-1*rotation_speed*horizontal_movement*Time.deltaTime);
        }
        if(Math.Abs(vertical_movement) > 0.01f)
        {
            car_transform.Translate(0, move_speed * vertical_movement*Time.deltaTime, 0f);
        }
    }
}
