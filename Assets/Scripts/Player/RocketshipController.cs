// rocket controls
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketshipController : MonoBehaviour
{
    public float moveSpeed = 100f;
    public float rotationSpeed = 10f;
    private Vector3 currentVelocity;
    public float velocitySmoothTime = 0.1f; // Smoothing time for velocity changes

    private Rigidbody rb;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        // Calculate movement vector based on input direction
        Vector3 moveDirection = transform.forward * direction.z * moveSpeed;

        // Apply movement to the rigidbody
      //  rb.MovePosition(rb.position + moveDirection);

        // Smoothly adjust the current velocity towards the target velocity
        currentVelocity = Vector3.SmoothDamp(currentVelocity, moveDirection, ref currentVelocity, velocitySmoothTime);

        // Apply the smoothed velocity to the Rigidbody
        rb.velocity = currentVelocity;

    }

    public void Rotate(Vector3 rotation)
    {
        // Calculate rotation vector based on input rotation
        Vector3 rotateDirection = rotation * rotationSpeed * Time.deltaTime;

        Vector3 rotation1 = new Vector3(-rotateDirection.y, rotateDirection.x, 0f) * rotationSpeed * Time.deltaTime;
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation1));
    }
}
