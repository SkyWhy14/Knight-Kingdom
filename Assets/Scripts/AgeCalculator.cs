using TMPro;
using UnityEngine;
using System;

public class AgeCalculator : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField birthYearInput;
    public TMP_Text resultText;

    public void CalculateAge()
    {
        string name = nameInput.text;

        if (string.IsNullOrEmpty(name))
        {
            resultText.text = "Ievadi vārdu!";
            return;
        }

        if (!int.TryParse(birthYearInput.text, out int birthYear))
        {
            resultText.text = "Ievadi pareizu dzimšanas gadu!";
            return;
        }

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        resultText.text = "Bruņinieks " + name + " ir " + age + " gadus vecs!";
    }
}