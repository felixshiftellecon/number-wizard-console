using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class WizardEditorTest
{
    public NumberWizard numberWizard = Object.FindObjectOfType<NumberWizard>();

    // A Test behaves as an ordinary method
    [Test]
    public void StartTest()
    {
        numberWizard.StartGame();

        Assert.AreEqual(1001, numberWizard.max);
        Assert.AreEqual(1, numberWizard.min);
        Assert.AreEqual(500, numberWizard.guess);
    }

    [Test]
    public void NextGuessTest()
    {
        numberWizard.max = 10;
        numberWizard.min = 1;

        numberWizard.NextGuess();

        Assert.AreEqual(5, numberWizard.guess);
    }

    [Test]
    public void LowGuessTest()
    {
        numberWizard.min = 1;
        numberWizard.guess = 5;

        numberWizard.LowGuess();

        Assert.AreEqual(numberWizard.min, numberWizard.guess);
    }

    [Test]
    public void HighGuessTest()
    {
        numberWizard.max = 10;
        numberWizard.guess = 5;

        numberWizard.HighGuess();

        Assert.AreEqual(numberWizard.max, numberWizard.guess);
    }
}
