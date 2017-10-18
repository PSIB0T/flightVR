using UnityEngine;
using System.Collections;

  [RequireComponent(typeof(CharacterController))]
public class AutoWalk : MonoBehaviour {
    // How fast to move
    public float speed = 3.0F;
    // Should I move forward or not
    public bool moveForward ;
    // CharacterController script
    private CharacterController controller;
    // VR Head
    private Transform vrHead;
    
    // Use this for initialization
    void Start () {
        // Find the CharacterController
        controller = GetComponent<CharacterController>();
       	
        // Fnd the VR Head
        vrHead = Camera.main.transform;
    }
    
    // Update is called once per frame
    void Update () {
    
        // In the Google VR button press
        if (Input.GetButtonDown("Fire1")){
            // Change the state of moveForward
            moveForward = !moveForward;
        }
        
        // Check to see if I should move
        if (moveForward) {
            // Find the forward direction
            Vector3 forward = vrHead.TransformDirection(Vector3.forward);
            // Tell CharacterController to move forward
            controller.Move(forward * speed);
        }
    }
}