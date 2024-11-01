using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPersoScript : MonoBehaviour
{
    public float vitesseDeplacementPerso = 5f; // Movement speed
    public float vitesseRotationPerso = 100f; // Rotation speed
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
        Vector3 movement = new Vector3(axeH, 0f, axeV).normalized * vitesseDeplacementPerso * Time.deltaTime;

        // Apply movement
        rb.MovePosition(transform.position + transform.TransformDirection(movement));

        // Get mouse input for rotation
        float sourisX = Input.GetAxis("Mouse X") * vitesseRotationPerso * Time.deltaTime;

        // Apply rotation
        transform.Rotate(0f, sourisX, 0f);
    }
}
