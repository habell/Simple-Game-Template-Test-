using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] 
    private Transform _followTransform;
    
    [SerializeField]
    private Vector3 _offset;
    
    private void Update()
    {
        if(_followTransform)
        {
            transform.position = _followTransform.position + _offset;
            transform.LookAt(_followTransform);
        }
    }
}
