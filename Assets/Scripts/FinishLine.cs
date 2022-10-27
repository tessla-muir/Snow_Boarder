using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public float finishTime = 1.2f;
    public ParticleSystem finishEffect;
    public AudioSource finishSound;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player") {
            finishEffect.Play();
            finishSound.Play();
            Invoke("finish", finishTime);
        }
    }

    void finish() {
        Debug.Log("You finished!");
        SceneManager.LoadScene("Level1");
    }
}
