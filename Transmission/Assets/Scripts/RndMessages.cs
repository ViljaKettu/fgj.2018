using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RndMessages : MonoBehaviour
{
    string[] texts = new string[] {"text1 ", "text3 ", "text3 " };
    string[] texts2 = new string[] { "laa ", "lalla ", "lala " };
    string[] texts3 = new string[] { "kissa", "koira", "marsu" };

    string currentText;
    string currentText2;
    string currentText3;

    public Text message;

    private void Start()
    {

        currentText = texts[Random.Range(0, texts.Length)];
        currentText2 = texts2[Random.Range(0, texts.Length)];
        currentText3 = texts3[Random.Range(0, texts.Length)];

        message.text = currentText + currentText2 + currentText3;
    }
}
