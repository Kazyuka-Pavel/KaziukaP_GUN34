using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class MoveMonster : MonoBehaviour
{

    private Rigidbody2D _rb;    

    [SerializeField]
    public Vector2 minPosition;
    [SerializeField]
    public Vector2 maxPosition;
    [SerializeField]
    private float _speed = 1f;

    private float _delay = 0;
    private Vector2 _moveVector2;
    private Vector2 _startPosition2;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(_delay == 0 || _delay > 3)
        {
            _moveVector2 = RandomizeVector();
            _delay = 0;
            _startPosition2 = _rb.position;
        }
        _delay += Time.deltaTime;
        
        _rb.MovePosition(_rb.position + _moveVector2 * _speed * Time.deltaTime);

        if (_delay > 0.1 && (_startPosition2 == _rb.position))
        {
            _delay = 0;
        }
    }

    private Vector2 RandomizeVector()
    {
        Vector2 randomPosition = new Vector3(Random.Range(minPosition.x, maxPosition.x),
        Random.Range(minPosition.y, maxPosition.y));

        return randomPosition;
    }
}
