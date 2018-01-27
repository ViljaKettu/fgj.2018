using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterInteraction : MonoBehaviour
{
    public SpriteRenderer img;
    public GameObject cm;
    public SceneController sc;
    public string[] lines;
    public string myName;

    //TESTI
    public bool mouseOver, clicked;
    public Sprite[] mats;

    void Start ()
    {
        img.sprite = mats[0];
        myName = transform.name;
	}

    private void OnMouseEnter()
    {
        if (sc.inConversation == false)
        {
            img.sprite = mats[1];
        }
    }

    private void OnMouseExit()
    {
        if (sc.inConversation == false)
        {
            img.sprite = mats[0];
        }
    }

    private void OnMouseDown()
    {
        if (sc.inConversation == false)
        {
            clicked = true;
            img.sprite = mats[0];

            sc.ActivateConversation(transform.gameObject, lines[UnityEngine.Random.Range(0, lines.Length)], myName);
        }
    }
}
