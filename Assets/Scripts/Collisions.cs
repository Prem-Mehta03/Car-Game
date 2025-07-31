using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public Car_Controller Car;
    public float Crash_Duration;

    private bool is_reduced = false;
    public float speedReduction_timer;
    private bool can_collide = true;

    // Update is called once per frame
    void Update()
    {
        if (is_reduced)
        {
            speedReduction_timer -= Time.deltaTime;
            if (speedReduction_timer < 0.0001f)
                EndCrash();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {   if (can_collide)
        {
            if (collision.gameObject.tag == "Red_House")
            {
                Debug.Log("You hit a red house.");
                StartCrash();
            }
            else if (collision.gameObject.tag == "Blue_House")
            {
                Debug.Log("You hit a blue house.");
                StartCrash();
            }
            else if (collision.gameObject.tag == "Brown_House")
            {
                Debug.Log("You hit a brown house.");
                StartCrash();
            }
            else if (collision.gameObject.tag == "Rock")
            {
                Debug.Log("You hit a rock on the way.");
                StartCrash();
            }
            else if (collision.gameObject.tag == "Tree")
            {
                Debug.Log("You hit a tree on the way.");
                StartCrash();
            }
        }
        if (collision.gameObject.tag == "Barrier")
        {
            Debug.Log("That area is out of bounds,Please stay on the track.");
        }
    }

    void StartCrash()
    {
        Car.move_speed /= 1.5f;
        can_collide = false;
        is_reduced = true;
        speedReduction_timer = Crash_Duration;
        Debug.Log($"Your speed has been reduced for {Crash_Duration} seconds.");
    }

    void EndCrash()
    {
        Car.move_speed *= 1.5f;
        is_reduced = false;
        can_collide = true;
        speedReduction_timer = 0f;
        Debug.Log("Your speed is back to normal");
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
}
