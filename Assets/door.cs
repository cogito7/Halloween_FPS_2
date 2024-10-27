using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator door = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;
    [SerializeField] private AudioSource doorOpenAudioSource = null;
    [SerializeField] private float openDelay = 0.0f;

    private void OnTriggerEnter(Collider other)
    {
        //print("Collision");
        //if (other.CompareTag("Player"))
        //{
            print("Play collision");
            if (openTrigger)
            {
                door.Play("dooropen", 0, 0.0f);
                gameObject.SetActive(false);
                doorOpenAudioSource.PlayDelayed(openDelay);
            }

            else if (closeTrigger)
            {
                door.Play("doorclose", 0, 0.0f);
                gameObject.SetActive(false);
            }
        //}

    }
}
