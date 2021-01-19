using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour
{   public Gamemanager gameManager;
   void OnTriggerEnter ()
   {
       gameManager.CompleteLevel();
   }
}
