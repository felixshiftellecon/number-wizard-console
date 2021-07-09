using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    public int max;
    public int min;
    public int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to the Number Wizard, muhahaha");
        Debug.Log("Pick a number between " + min + " and " + max + " please :3");
        Debug.Log("Is your number higher or lower than " + guess + " ?");
        Debug.Log("Press Up Arrow for higher, Down Arrow for lower, and Enter if I'm right");

        max += 1;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            LowGuess();
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            HighGuess();
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            CorrectGuess();
            StartGame();
        }
    }

    public void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("What about " + guess + "?");
    }

    public void LowGuess()
    {
        Debug.Log("The guess was too low huh?");
        min = guess;
    }
    public void HighGuess()
    {
        Debug.Log("The guess was too high huh?");
        max = guess;
    }
    public void CorrectGuess()
    {
        Debug.Log("The guess of " + guess + " was correct, bwhahahaha");
        Debug.Log("Hang on, we can play again!");
    }
}