using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mr;
    Rigidbody rb;

    [SerializeField] float timeToWait = 3f;
    [SerializeField] float runTime = 0f;


    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.enabled = false; 
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void Update()
    {
        runTime += Time.deltaTime;
        if (runTime>=timeToWait)
        {
            ActivateMeshRenderer();
            ActivateGravity();
        }
    }

    private void ActivateMeshRenderer()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }

    private void ActivateGravity()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
