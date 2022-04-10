using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narizEnemyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        var tag = other.gameObject.tag;
        if (tag == "jugador")
        {
            Destroy(other.gameObject);
        }
    }
}
