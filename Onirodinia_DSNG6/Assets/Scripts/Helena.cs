using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Helena : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;
    public float Speed;
    public float JumpForce;
    public bool IsJumping;
    public bool DoubleJump;


    // Start is called before the first frame update
    void Start()
    {
        try{
            rig = GetComponent<Rigidbody2D>(); 
            anim = GetComponent<Animator>();
        }
        catch(NullReferenceException e){
            Debug.Log("Erro: "+ e);

        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        try{
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * Speed;
            //Direita
            if(Input.GetAxis("Horizontal") > 0f){
                anim.SetBool("run", true);
                transform.eulerAngles = new Vector3(0f,0f,0f);
            }
            //Esquerda
            if(Input.GetAxis("Horizontal") < 0f){
                anim.SetBool("run", true);
                transform.eulerAngles = new Vector3(0f,180f,0f);
            }
            //Parado
            if(Input.GetAxis("Horizontal") == 0f){
                anim.SetBool("run", false);
            }
        }
        catch(NullReferenceException e){
            Debug.Log("Erro: "+ e);

        }
    }
void Jump()
    {
        try{
            if(Input.GetButtonDown("Jump"))
            {
                if(!IsJumping)
                {
                    rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                }
                else
                {
                    if(DoubleJump == true)
                    {
                        rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                        DoubleJump = false;
                    }
                }
            }
        }
        catch(NullReferenceException e){
            Debug.Log("Erro: "+ e);

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        try{
            if(collision.gameObject.layer == 6)
            {
                IsJumping = false;
                DoubleJump = true;
                anim.SetBool("jump", false);
            }
        }
        catch(NullReferenceException e){
            Debug.Log("Erro: "+ e);

        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        try{
            if(collision.gameObject.layer == 6)
            {
                IsJumping = true;
                anim.SetBool("jump", true);
            }
        }
        catch(NullReferenceException e){
            Debug.Log("Erro: "+ e);

        }
    }
}