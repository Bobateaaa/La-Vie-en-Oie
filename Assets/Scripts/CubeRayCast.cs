using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRayCast : MonoBehaviour
{
    public GameObject cible;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Ray rayon = Camera.main.ScreenPointToRay(Input.mousePosition);

        // RaycastHit collision;

        // if (Physics.Raycast(rayon.origin, rayon.direction, out collision, 5000, LayerMask.GetMask("plancher")))
        // {
        //     print(collision.point);
        //     transform.position = collision.point;
        //     transform.position = transform.TransformPoint(0, 1, 0);
        // }

        // Debug.DrawRay(rayon.origin, rayon.direction * 100, Color.yellow);
    }
    void OnMouseDown()
    {
        Ray rayon = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit collision;

        if (Physics.Raycast(rayon.origin, rayon.direction, out collision, 5000, LayerMask.GetMask("plancher")))
        {
            print(collision.point);
            cible.transform.position = collision.point;
            cible.transform.position = cible.transform.TransformPoint(0, 1, 0);
        }

        Debug.DrawRay(rayon.origin, rayon.direction * 100, Color.yellow);
    }

}
