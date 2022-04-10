using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float JumpForce = 10;
    public float velocity = 10;
    private Rigidbody2D _rb;
    private Animator _animator;
    private SpriteRenderer _sr;
    private static readonly string ANIMATOR_STATE = "Estado";
    private static readonly int ANIMATION_SLICE = 2;
    private static readonly int ANIMATION_JUMP = 1;
    private static readonly int ANIMATION_RUN = 0;
    private static readonly int RIGHT = 1;
    //private static readonly int LEFT = -1;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       Desplazarse(RIGHT);
       if (Input.GetKey(KeyCode.C)) //si presiona la flecha a la derecha
       {
           Deslizarse();
       }

       if (Input.GetKeyUp(KeyCode.Space)) //cada vez que suelto la tecla salta
       {
           _rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse); //ayuda para el tipo de fuerza
           ChangeAnimation(ANIMATION_JUMP);
       }
    }
    private void Desplazarse(int position)
    {
        _rb.velocity = new Vector2(velocity * position, _rb.velocity.y);
        ChangeAnimation(ANIMATION_RUN);
    }
    private void Deslizarse()
    {
        ChangeAnimation(ANIMATION_SLICE);
    }

    private void ChangeAnimation(int animation)
    {
        _animator.SetInteger(ANIMATOR_STATE,animation);
    }

}
