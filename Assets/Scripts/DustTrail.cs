using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    public ParticleSystem snowTrail;

    // Show snow trail if touching ground
    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Ground")
        {
            snowTrail.Play();
        }
    }

    // Stop snow trail if not touching ground
    void OnCollisionExit2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Ground")
        {
            snowTrail.Stop();
        }
    }
}
