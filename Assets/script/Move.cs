using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 defaultpass;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultpass = transform.position;
    }

    void Update()
    {
        //Xç¿ïWÇÃÇ›â°à⁄ìÆ
        rb.MovePosition(new Vector2(defaultpass.x + Mathf.PingPong(Time.time, 3), defaultpass.y));
    }
}
