using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piesPlayerController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        var tag = other.gameObject.tag;
        if (tag == "enemigo")
        {
            Destroy(other.gameObject);
        }
    }
}
