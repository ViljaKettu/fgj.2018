using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    void Start()
    {
        GameObject ngo = new GameObject("myTextGO");
        ngo.transform.SetParent(this.transform);

        Text myText = ngo.AddComponent<Text>();
        myText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        myText.text = "Ta-dah!";
    }

}
