using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    AudioClip footsteps;
    AudioSource audio;

    public float speed, hor, ver;
    public bool canMove;
    Rigidbody2D rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }
	
	void Update ()
    {

        PlaySound();
        if (canMove)
        {
            hor = Input.GetAxisRaw("Horizontal");
            ver = Input.GetAxisRaw("Vertical");
            rb.MovePosition(rb.position + new Vector2(hor, ver) * speed * Time.deltaTime);
        }
    }

    void PlaySound()
    {
        if(!audio.isPlaying)
        {
            if (Mathf.Abs(hor) > 0 || Mathf.Abs(ver) > 0)
            {
                audio.Play();
            }
        }
        else if (hor == 0 && ver == 0)
        {
            audio.Stop();
        }

    }
}
