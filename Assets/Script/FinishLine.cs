using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameManager gameManager;
    
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            gameManager.LevelComplete();
            
        }
    }
}
