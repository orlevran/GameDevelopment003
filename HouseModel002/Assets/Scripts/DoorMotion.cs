﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    public Animator animator;
    public GameObject door_axisR, door_axisL, door;
    public bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        animator = door.GetComponent<Animator>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera") || other.CompareTag("NPC") || other.CompareTag("Player"))
        {
            animator.SetTrigger("Open");
            isOpen = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (isOpen)
        {
            animator.SetTrigger("Close");
            isOpen = false;
        }
    }
}
