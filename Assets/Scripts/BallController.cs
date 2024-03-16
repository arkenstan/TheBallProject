using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private Rigidbody rb;

    private void Update() {
        CheckInputs();
    }

    private void CheckInputs()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        var forceVector = new Vector3(horizontalInput * speed, 0, verticalInput * speed);
        rb.AddForce(forceVector);
    }
}
