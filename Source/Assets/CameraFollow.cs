using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private Transform targetToFollow;

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow.position.x, -15f, 20f),
            Mathf.Clamp(targetToFollow.position.y, 0f, 25f),
            transform.position.z);
    }
}
