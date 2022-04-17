using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Transform _camera;
    private Rigidbody _rigidbody;

    private void Start()
    {
        if (!_camera)
        {
            _camera = Game.Instance.Camera.transform;
            Debug.LogError("ERROR Camera in PlayerMovement is null.");
        }
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        var direction = new Vector3(horizontal, 0f, vertical);
        var moveDirection = _camera.rotation * direction;
        moveDirection.y = 0f;
        _rigidbody.AddForce(moveDirection);
    }
}
