using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowPlayer : MonoBehaviour
{
    public birdMovement birdMovement;

    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(birdMovement.transform.position.x + offset.x, offset.y, offset.z);
    }
}
