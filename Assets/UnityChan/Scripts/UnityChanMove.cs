using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanMove : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        float v;
        v = Input.GetAxis("Vertical");
        animator.SetFloat("speed", v);

        if (Input.GetKeyDown("space"))
        {
            print("success");
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }
    }
}
