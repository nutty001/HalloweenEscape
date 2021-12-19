using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    public float climbingspeed = 6;

    //LadderMovement
    private void OnTriggerStay2D(Collider2D other)
    { 
        if(other.tag=="Player"&&Input.GetKey(KeyCode.W))
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, climbingspeed);
        }
        else if (other.tag == "Player" && Input.GetKey(KeyCode.S))
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -climbingspeed);
        }
        else
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0,1);
        }
    }
}
