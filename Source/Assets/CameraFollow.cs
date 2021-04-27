using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;
    public float upperBounds;
    public float lowerBounds;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
        Mathf.Clamp(targetToFollow.position.x, lowerBounds, upperBounds),
        Mathf.Clamp(targetToFollow.position.y, lowerBounds, upperBounds),
        transform.position.z);
    }
}
