using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMotion : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            animator.SetInteger("Condition", 1);
        else if(Input.GetKeyUp(KeyCode.UpArrow))
            animator.SetInteger("Condition", 0);
    }
}
