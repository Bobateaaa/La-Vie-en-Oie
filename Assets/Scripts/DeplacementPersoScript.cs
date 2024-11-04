using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPersoScript : MonoBehaviour
{
    public float vitesseDeplacement = 4f; // Movement speed
    public float vitesseRotation = 100f; // Rotation speed
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.useGravity = true;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ; // Freeze rotation on X and Z axes
    }

    void FixedUpdate()
    {
        // Get input for movement
        float axeH = Input.GetAxis("Horizontal");
        float axeV = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(axeH, 0f, axeV).normalized * vitesseDeplacement * Time.deltaTime;

        // Apply movement
        rb.MovePosition(transform.position + transform.TransformDirection(movement));

        transform.Rotate(0, axeH * vitesseRotation * Time.deltaTime, 0);

    }
}
