using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalculatorController : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    private string inputString = "";
    private string currentNumber = "";
    private float firstNumber;
    private float secondNumber;
    private string operation;

    public void OnNumberButtonPressed(string number)
    {
        MainSfxController.Instance.PlaySound();
        currentNumber += number;
        inputString += number;
        UpdateDisplay();
    }

    public void OnOperationButtonPressed(string op)
    {
        MainSfxController.Instance.PlaySound();
        if (currentNumber != "")
        {
            firstNumber = float.Parse(currentNumber);
            inputString += "" + op + "";
            operation = op;
            currentNumber = "";
            UpdateDisplay();
        }
    }

    public void OnEqualsButtonPressed()
    {
        MainSfxController.Instance.PlaySound();
        if (currentNumber != "")
        {
            secondNumber = float.Parse(currentNumber);
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
            inputString = result.ToString();
            currentNumber = inputString;
            firstNumber = result;
            secondNumber = 0;
            operation = "";
        }
    }

    public void OnClearButtonPressed()
    {
        MainSfxController.Instance.PlaySound();
        inputString = "";
        currentNumber = "";
        firstNumber = 0;
        secondNumber = 0;
        operation = "";
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        displayText.text = inputString;
    }
    public void OnDeleteButtonPressed()
    {
        MainSfxController.Instance.PlaySound();
        if (!string.IsNullOrEmpty(inputString))
        {
            inputString = inputString.Substring(0, inputString.Length - 1);
            currentNumber = inputString.EndsWith(" ") ? "" : inputString.Split(' ')[^1];
            UpdateDisplay();
        }
    }
    public void OnPercentageButtonPressed()
    {
        MainSfxController.Instance.PlaySound();
        if (!string.IsNullOrEmpty(currentNumber))
        {
            float number = float.Parse(currentNumber);
            number /= 100;
            currentNumber = number.ToString();
            inputString = inputString.Substring(0, inputString.Length - currentNumber.Length) + currentNumber;
            UpdateDisplay();
        }
    }
}
