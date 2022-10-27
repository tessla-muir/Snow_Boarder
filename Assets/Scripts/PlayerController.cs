using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float torqueAmount = 1.5f;
    public float normalSpeed = 12f;
    public float boostSpeed = 20f;
    bool canMove = true;
    

    Rigidbody2D rb;
    SurfaceEffector2D surfaceEffector2D;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update() 
    {
        if (canMove) {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControls() 
    {
        canMove = false;
    }

    // Rotates player based on keyboard input
    void RotatePlayer() 
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddTorque(-torqueAmount);
        }
    }

    // Boost player if player pushes up key
    void RespondToBoost()
    {
        if (Input.GetAxis("Vertical") > 0 || Input.GetKey("up"))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = normalSpeed;
        }
    }
}
