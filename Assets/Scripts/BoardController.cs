using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;

    private void Update()
    {
        var zRotation = -Input.GetAxis("Horizontal") * speed;
        var xRotation = Input.GetAxis("Vertical") * speed;

        xRotation *= Time.deltaTime;
        zRotation *= Time.deltaTime;

        transform.Rotate(xRotation, 0, zRotation);
    }
}
