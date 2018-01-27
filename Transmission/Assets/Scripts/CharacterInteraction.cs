using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterInteraction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public Image img;
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
	}

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        img.sprite = mats[1];
        mouseOver = true;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        img.sprite = mats[0];
        mouseOver = false;
    }
    
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        clicked = true;

        sc.ActivateConversation(transform.gameObject, lines[UnityEngine.Random.Range(0, lines.Length)], myName);
    }
}
