using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private float fHorPlayAccel = 5000f;
    private Rigidbody2D ourRigidbody;

    private void Start()
    {
         ourRigidbody = GetComponent<Rigidbody2D>();
    }


    public void Move(float horizontalInput)
    {
        

        if (horizontalInput != 0.0f)
        {
            var forceToAdd = Vector2.right * (horizontalInput * fHorPlayAccel * Time.deltaTime);
            
            ourRigidbody.AddForce(forceToAdd);
        }
    }
}
