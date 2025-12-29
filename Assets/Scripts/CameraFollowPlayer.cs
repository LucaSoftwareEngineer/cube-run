using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void LateUpdate()
    {
        float xFissa = offset.x;
        float yFissa = player.position.y + offset.y;
        float zInseguimento = player.position.z + offset.z;

        transform.position = new Vector3(xFissa, yFissa, zInseguimento);
    }
}
