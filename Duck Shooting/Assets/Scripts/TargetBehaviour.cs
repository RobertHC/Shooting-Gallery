using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour {

    private bool beenHit = false;
    private Animator animator;
    private GameObject parent;

    void Start()
    {
        parent = transform.parent.gameObject;
        animator = parent.GetComponent<Animator>();
    }

    /// <summary>
    /// Called whenever the player clicks on the object.
    /// only works if you have a collider on the object
    /// </summary>
    void OnMouseDown()
    {
        // Is it valid to hit it
        if (!beenHit)
        {
            beenHit = true;
            animator.Play("Flip");
        }
    }
}