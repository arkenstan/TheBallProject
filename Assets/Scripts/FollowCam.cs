using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField]
    Vector3 offset = Vector3.zero;

    [SerializeField]
    Transform target;

    private void Update()
    {
        transform.position = target.position + offset;
    }
}
