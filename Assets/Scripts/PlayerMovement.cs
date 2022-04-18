using DefaultNamespace;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private CameraFollow _camera;
    
    private Rigidbody _rigidbody;

    public float Speed => _speed;

    private void Start()
    {
        if (!_camera)
        {
            _camera = Game.Instance.Camera.GetComponent<CameraFollow>();
            _camera.FollowTransform = transform;
        }
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        var direction = new Vector3(horizontal, 0f, vertical);
        var moveDirection = _camera.transform.rotation * direction * _speed;
        moveDirection.y = 0f;
        _rigidbody.AddForce(moveDirection);
    }
}
