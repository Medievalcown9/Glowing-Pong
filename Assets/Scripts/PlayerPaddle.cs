using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    private Color paddleColor;
    private SpriteRenderer rend;

    private void Start()
    {
        paddleColor = PlayerPrefsExtra.GetColor("PaddleColor");
        rend = GetComponent<SpriteRenderer>();
        rend.color= paddleColor;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        } else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        } else
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if(_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
