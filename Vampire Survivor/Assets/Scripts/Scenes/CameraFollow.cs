using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target = null;
    public Vector3 offset = Vector3.zero;

    private void LateUpdate()
    {
        offset.x = 5f; 
        offset.y = 20f;
        transform.position = target.transform.position + offset;
        transform.LookAt(target.transform);
    }
}