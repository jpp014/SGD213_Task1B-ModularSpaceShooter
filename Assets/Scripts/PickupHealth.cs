using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHealth : Pickup
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject player = col.gameObject;
            HandlePlayerPickup(player);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject player = col.gameObject;
            HandlePlayerPickup(player);
            Destroy(gameObject);
        }
    }
    private new void HandlePlayerPickup(GameObject player)
    {
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        playerHealth.Heal(100);
    }
}
