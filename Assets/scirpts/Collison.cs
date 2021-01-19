using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{   public Movement movement;
    
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisonInfo)
    {
        if (collisonInfo.collider.tag == "Obstacles")
        {
            
            movement.enabled =false; 
            FindObjectOfType<Gamemanager>().EndGame();
        }
    }
}
