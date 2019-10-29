using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charinentory1 : MonoBehaviour
{
    //Declare Variables
    public int appleCount = 0;
    public GameObject crate;

    //when collide with trigger
    //if the other thing is tagged "apple"
    //then add 1 to our appleCount
    //and if appleCount is > x, Crate. Setactive(false)
    private void OnTriggerEnter2D(Collider2D other)
    {
        if((other.gameObject.CompareTag"apple"))

            Debug.Log("you got an apple");
        appleCount += 1;
        if(appleCount >= 2)
        {

            crate.SetActive(false) 
        }
    }
}
