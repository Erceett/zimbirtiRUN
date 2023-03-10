using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3.0f;
    void Start()
    {
        printInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }
    
    void printInstructions() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move the player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void playerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
