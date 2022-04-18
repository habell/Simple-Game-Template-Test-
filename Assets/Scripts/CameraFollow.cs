using UnityEngine;
using UnityEngine.Serialization;

public class CameraFollow : MonoBehaviour
{
    public Transform FollowTransform;
    
    [SerializeField] private Vector3 _offset;
    
    private void Update()
    {
        if(FollowTransform)
        {
            transform.position = FollowTransform.position + _offset;
            transform.LookAt(FollowTransform);
        }
    }
}
