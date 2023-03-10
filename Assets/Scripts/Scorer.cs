using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumped = 0;
    //[SerializeField]int hitPoint = 10;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            bumped++;
            Debug.Log("You've bumped into a thing this many times:" + bumped);
        }
        
        //HitPoint();
    }

    /*private void HitPoint()
    {
        hitPoint--;
        if (hitPoint == 0)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }*/
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
