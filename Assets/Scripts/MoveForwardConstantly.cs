using UnityEngine;


public class MoveForwardConstantly : MonoBehaviour
{
    
    [SerializeField] float acceleration;

    [SerializeField]  float initialVelocity;
    
    private enum Directions
    {
        Up = 1,
        Down = -1
    };

    [SerializeField] private Directions directions;
    private Rigidbody2D ourRigidbody;


    // Use this for initialization
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.velocity = new Vector2(0f, (float)directions) * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        var forceToAdd =new Vector2(0f, (float)directions) * (acceleration * Time.deltaTime);
        
        ourRigidbody.AddForce(forceToAdd);
    }
}


