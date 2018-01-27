using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    AudioClip footsteps;
    AudioSource source;

    public float speed, hor, ver;
    public bool canMove;
    Rigidbody2D rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        transform.position = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().SetPlayerLocation();
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
        if(!source.isPlaying)
        {
            if (Mathf.Abs(hor) > 0 || Mathf.Abs(ver) > 0)
            {
                source.Play();
            }
        }
        else if (hor == 0 && ver == 0)
        {
            source.Stop();
        }

    }
}
