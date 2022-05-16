using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    
    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, 0.72f, 0f) + offset;
    }
}
