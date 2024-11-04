using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPerso : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("vitesseVerticale", Input.GetAxis("Vertical"));
        anim.SetFloat("vitesseHorizontale", Input.GetAxis("Horizontal"));

    }
}
