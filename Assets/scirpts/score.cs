using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {  
        scoreText.text = player.position.z.ToString("0") ;
    }
}
