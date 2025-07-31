using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BoostTimer : MonoBehaviour
{
    // Start is called before the first frame update

    public Car_Controller Car;
    public float Boost_Duration;

    private bool is_boosted = false;
    public float boost_timer;


    // Update is called once per frame
    void Update()
    {
       if(is_boosted)
        {
            boost_timer -= Time.deltaTime;
            if (boost_timer < 0.0001f)
                EndBoost();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Boost")
        {
            StartBoost();
            GameObject.Destroy(collision.gameObject);
        }
    }

    void StartBoost()
    {
        Car.move_speed *= Car.Boost_Multiplier;
        is_boosted = true;
        boost_timer = Boost_Duration;
        Debug.Log($"Boost has been activated for {boost_timer} seconds.");
    }

    void EndBoost()
    {
        Car.move_speed /= Car.Boost_Multiplier;
        is_boosted = false;
        boost_timer = 0;
        Debug.Log("Boost has worn off.");
    }
}
