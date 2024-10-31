using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanceVitesse : MonoBehaviour
{
    Rigidbody rb;
    public float vitesse;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(this.gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * vitesse;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ennemi")
        {
            print("hello");
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        Destroy(this.gameObject);
    }
}
