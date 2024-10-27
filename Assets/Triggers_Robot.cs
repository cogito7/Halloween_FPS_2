using UnityEngine;

public class LocationBasedTrigger : MonoBehaviour
{
    public Animator animator;  // Reference to the Animator component
    public float triggerXPosition = -0.2f;  // The Z position that triggers the animation

    void Update()
    {
        // Check if the object's X position is greater than or equal to the triggerXPosition
        if (transform.position.x <= triggerXPosition)
        {
            // Set the trigger to start the animation
            animator.SetTrigger("StartAnimation");
        }
    }
}
