using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed, hor, ver;
    public bool canMove;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        if(canMove)
        {
            hor = Input.GetAxisRaw("Horizontal");
            ver = Input.GetAxisRaw("Vertical");

            transform.Translate(new Vector2(hor, ver) * speed * Time.deltaTime);
        }
	}
}
