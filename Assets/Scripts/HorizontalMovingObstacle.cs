using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class HorizontalMovingObstacle : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _leftLimit;
    [SerializeField] private float _rightLimit;

    private bool _isMovingLeft;

    private void Update()
    {
        if (_isMovingLeft)
        {
            transform.Translate(Vector3.left * (_speed * Time.deltaTime));
            if (transform.position.x <= _leftLimit)
            {
                _isMovingLeft = false;
            }
        }
        else
        {
            transform.Translate(Vector3.right * (_speed * Time.deltaTime));
            if (transform.position.x >= _rightLimit)
            {
                _isMovingLeft = true;
            }
        }
    }
}