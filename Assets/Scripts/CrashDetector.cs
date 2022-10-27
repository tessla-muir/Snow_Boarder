using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    public float respawnTime = 1.2f;
    public ParticleSystem deathEffect;
    public AudioSource deathSound;
    bool hasDied = false;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Ground" && !hasDied)
        {
            hasDied = true;
            FindObjectOfType<PlayerController>().DisableControls();
            deathEffect.Play();
            deathSound.Play();
            Invoke("death", respawnTime);
        }
    }

    void death() {
        Debug.Log("You finished!");
        SceneManager.LoadScene("Level1");
    }
}
