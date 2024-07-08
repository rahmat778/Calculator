using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalculatorController : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    private string inputString = "";
    private float firstNumber;
    private float secondNumber;
    private string operation;

    public void OnNumberButtonPressed(string number)
    {
        inputString += number;
        UpdateDisplay();
    }

    public void OnOperationButtonPressed(string op)
    {
        if (inputString != "")
        {
            firstNumber = float.Parse(inputString);
            inputString = "";
            operation = op;
            UpdateDisplay();
        }
    }

    public void OnEqualsButtonPressed()
    {
        if (inputString != "")
        {
            secondNumber = float.Parse(inputString);
            float result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "−":
                    result = firstNumber - secondNumber;
                    break;
                case "×":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        displayText.text = "Error";
                        return;
                    }
                    break;
            }
            inputString = result.ToString();
            UpdateDisplay();
        }
    }

    public void OnClearButtonPressed()
    {
        inputString = "";
        firstNumber = 0;
        secondNumber = 0;
        operation = "";
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        displayText.text = inputString;
    }
}
