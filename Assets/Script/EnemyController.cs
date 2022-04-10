using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float JumpForce = 10;
    public float velocity = 10;
    private Rigidbody2D _rb;
    //private Animator _animator;
    private SpriteRenderer _sr;
    //private static readonly string ANIMATOR_STATE = "Estado";
    //private static readonly int ANIMATION_RUN = 0;
    private static readonly int LEFT = -1;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_animator = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Desplazarse(LEFT);
    }
    private void Desplazarse(int position)
    {
        _rb.velocity = new Vector2(velocity * position, _rb.velocity.y);
        //ChangeAnimation(ANIMATION_RUN);
    }
    //private void ChangeAnimation(int animation)
    //{
        //_animator.SetInteger(ANIMATOR_STATE,animation);
    //}
}
