using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossHair : MonoBehaviour
{
    public GameObject negativeText;
    public GameObject positiveText;
    public void NegativeText(string text)
    {
        negativeText.GetComponent<Text>().text = text;
        Instantiate(negativeText, transform, false);
    }
    public void PositiveText(string text)
    {
        positiveText.GetComponent<Text>().text = text;
        Instantiate(positiveText, transform, false);
    }
}
