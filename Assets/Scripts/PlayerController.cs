using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1.5f;
    Rigidbody2D rg2d;

    void Start()
    {
       rg2d = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rg2d.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            rg2d.AddTorque(-torqueAmount);
        }
    }
}
