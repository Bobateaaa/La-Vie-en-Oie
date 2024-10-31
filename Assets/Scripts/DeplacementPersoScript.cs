using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPersoScript : MonoBehaviour
{
    public float vitesseDeplacementPerso; // vitesse de déplacement du personnage
    public float vitesseRotationPerso; // vitesse de rotation du personnage lorsque la souris se déplace horizontalement
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true; // Ensure gravity is enabled
    }

    void FixedUpdate()
    {
        // Get input for movement and rotation
        float axeH = Input.GetAxisRaw("Horizontal");
        float axeV = Input.GetAxisRaw("Vertical");

        // Calculate movement
        Vector3 deplacement = new Vector3(axeH, 0f, axeV).normalized;
        rb.AddRelativeForce(deplacement * vitesseDeplacementPerso * Time.deltaTime, ForceMode.VelocityChange);

        // Define a constant rotation speed
        float constantRotationSpeed = 30f; // Adjust this value as needed

        // Get mouse input for rotation
        float sourisX = Input.GetAxis("Mouse X") * vitesseRotationPerso * Time.deltaTime;

        // Check if there is mouse movement
        if (sourisX != 0)
        {
            // Combine mouse input with constant rotation speed
            float totalRotation = sourisX + (constantRotationSpeed * Time.deltaTime);

            // Apply rotation
            transform.Rotate(0f, totalRotation, 0f);
        }
    }
}