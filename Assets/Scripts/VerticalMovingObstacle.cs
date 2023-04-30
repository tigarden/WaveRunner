using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingObstacle : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    private Vector3 _startPosition;

    private bool _isMovingUp = true;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        var newPosition = transform.position;
        if (_isMovingUp)
        {
            newPosition.y += _speed * Time.deltaTime;
            if (newPosition.y - _startPosition.y >= _distance)
            {
                _isMovingUp = false;
            }
        }
        else
        {
            newPosition.y -= _speed * Time.deltaTime;
            if (_startPosition.y - newPosition.y >= _distance)
            {
                _isMovingUp = true;
            }
        }

        transform.position = newPosition;
    }
}