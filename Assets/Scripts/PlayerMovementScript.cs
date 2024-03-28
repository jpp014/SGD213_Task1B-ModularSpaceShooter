using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
            
    // HorizontalPlayerAcceleration indicates how fast we accelerate Horizontally
    [SerializeField] private float fHorPlayAccel = 5000f;
    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    private void Start() {
    // Get OurRigidbodyComponent once at the start of the game and store a reference to it
    // This means that we don't need to call GetComponent more than once! This makes our game faster. (GetComponent is SLOW)
    ourRigidbody = GetComponent<Rigidbody2D>(); }
    // Update is called once per frame
    private void Update() {
        var horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0.0f) { 
            var forceToAdd = Vector2.right*(horizontalInput*fHorPlayAccel*Time.deltaTime);
            ourRigidbody.AddForce(forceToAdd);
            //print(HorizontalInput);
        }
    } 
}
