using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boarders : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {

            //Application.LoadLevel(Application.loadedLevel);
            LoseMenu.Show();
           
        }
    }
    
}
