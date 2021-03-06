﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : MonoBehaviour
{
    [SerializeField]
    Animator anim;

    [SerializeField]
    GameObject drop;

    int life = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FireBall"))
        {
            life--;
            anim.SetTrigger("Hit");
            Destroy(other.gameObject);
            if (life <= 0)
            {
                Instantiate(drop, gameObject.transform.position, gameObject.transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
