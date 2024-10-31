using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public birdMovement birdMovement;

    public GameManager GameManager;

    public AudioSource dieAudio;

    public AudioSource scoreAudio;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            birdMovement.enabled = false;
            GameManager.EndGame();
            dieAudio.Play();
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Score")
        {
            scoreAudio.Play();
            GameManager.AddScore();
        }
    }
}
