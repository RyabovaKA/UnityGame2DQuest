using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    private Animator anim;
    public VectorValue pos;
    public float speed;
    public float moveInput;
    AudioSource audioSrc;
    bool isMoving = false;

    private Rigidbody2D rb;

    void Start()
    {
        transform.position = pos.initialValue;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        audioSrc = GetComponent<AudioSource>();
    }


    void FixedUpdate()
    {
       moveInput = Input.GetAxis("Horizontal");
        if (rb.velocity.x != 0)
            isMoving = true;
        else
            isMoving = false;

        if (isMoving)
        {
            if (!audioSrc.isPlaying)
                audioSrc.Play();
        }
        else
            audioSrc.Stop();

        rb.velocity = new Vector2(moveInput* speed , rb.velocity.y);
      
       anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        //Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        //transform.position = transform.position + horizontal * 5f * Time.deltaTime;
    }
}
