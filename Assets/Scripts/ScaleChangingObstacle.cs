using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChangingObstacle : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _minScale;
    [SerializeField] private float _maxScale;

    private bool _isScalingUp;

    private void Update()
    {
        if (_isScalingUp)
        {
            transform.localScale += Vector3.one * (_speed * Time.deltaTime);
            if (transform.localScale.x >= _maxScale)
            {
                _isScalingUp = false;
            }
        }
        else
        {
            transform.localScale -= Vector3.one * (_speed * Time.deltaTime);
            if (transform.localScale.x <= _minScale)
            {
                _isScalingUp = true;
            }
        }
    }
}