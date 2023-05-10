using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    private Vector2 _startPosition;
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private Vector2 finishPosition;
    private float _deltaTime;
    private bool _triggerEnter = false;
    private void Awake()
    {
        _startPosition = _gameObject.transform.localPosition;
        _deltaTime = 0;
    }

    private void Update()
    {
        if (_triggerEnter == true)
        {
            _deltaTime += Time.deltaTime * speed;
            _gameObject.transform.position = Vector2.Lerp(_startPosition, finishPosition, _deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            _triggerEnter = true;
        }
        
    }


}
