using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guess_Game : MonoBehaviour
{   
    public int min = 0, max = 1000;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        guess = (max + min) / 2;
        Debug.Log("Welcome to the guessing game , Think of a number between 1 and 1000 and do not tell me");
        Debug.Log("My guess is " + guess);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (min + max) / 2;
            Debug.Log("So your number is higher, I guess to be :" + guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("So your number is lower, I guess to be :" + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Equals))
        {
            Debug.Log("Gotcha!!!");
        }
    }
}
