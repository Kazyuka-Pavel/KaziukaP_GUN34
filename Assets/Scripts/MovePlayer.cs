using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _speed = 2f;
    private Vector2 _moveVector;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }    

    private void FixedUpdate()
    {
        _moveVector.x = Input.GetAxis("Horizontal");
        _moveVector.y = Input.GetAxis("Vertical");
        _rb.MovePosition(_rb.position + _moveVector * _speed * Time.deltaTime);
    }
}
