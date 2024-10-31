using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdMovement : MonoBehaviour
{
    public Rigidbody rb;

    public AudioSource jumpAudio;

    public float xSpeed;

    public float jumpForce;

    public float gravity;

    public bool isStart;
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = false;
        jumpAudio.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if(isStart){

            rb.velocity = new Vector3(xSpeed, rb.velocity.y - gravity, rb.velocity.z);

            rb.rotation = Quaternion.Euler(0, 0, rb.velocity.y * 1.5f);
        }
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            isStart = true;
            rb.useGravity = true;
            Jump();
        }
        
    }
        private void Jump(){
            jumpAudio.Play();
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
}
