using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
        Mathf.Clamp(targetToFollow.position.x, -100, 100f),
        Mathf.Clamp(targetToFollow.position.y, -100, 100f),
        transform.position.z);
    }
}
