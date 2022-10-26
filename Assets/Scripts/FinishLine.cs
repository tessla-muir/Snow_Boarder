using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public float finishTime = 1.2f;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player") {
            Invoke("finish", finishTime);
        }
    }

    void finish() {
        Debug.Log("You finished!");
        SceneManager.LoadScene("Level1");
    }
}
