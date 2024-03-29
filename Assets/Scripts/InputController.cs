using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputController : MonoBehaviour
{
    private MovementComponent movementComponent;

    private ShootingComponent shootingComponent;
    // Start is called before the first frame update
    void Start()
    {
        movementComponent = GetComponent<MovementComponent>();
        shootingComponent = GetComponent<ShootingComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movementComponent)
        {
            var horizontalInput = Input.GetAxis("Horizontal");
            movementComponent.Move(horizontalInput);
        }

        if (shootingComponent)
        { 
            if (Input.GetButton("Fire1"))
            {
                shootingComponent.shoot();
            }
        }
           
    }
}
