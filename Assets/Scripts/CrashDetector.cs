using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    public float respawnTime = 1.2f;
    public ParticleSystem deathEffect;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Ground")
        {
            deathEffect.Play();
            Invoke("death", respawnTime);
        }
    }

    void death() {
        Debug.Log("You finished!");
        SceneManager.LoadScene("Level1");
    }
}
