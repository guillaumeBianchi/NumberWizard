using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardConsole : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess;
    bool guessed = false;
    bool finished = false;

    // Start is called before the first frame update. Runs once when the game starts.
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Welcome to number wizard console");
        Debug.Log("Think about a number.");
        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("The lowest number you can pick is " + min);
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!finished)
        {
            if (!guessed)
                guessed = NextGuess();

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = guess;
                guessed = false;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = guess;
                guessed = false;
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("I win !");
                finished = true;
            }
        }
    }

    bool NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up = Higher, Push down = lower, Push Enter = Correct");

        return true;
    }
}
