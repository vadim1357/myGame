using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseMenu : MonoBehaviour
{
    public Text text2;
    static private LoseMenu instance;
    

    public static void Show()
    {
        instance.text2.text = "Game Over!!!\nPress \"T\"";
        Time.timeScale = 0;
        
    }
    private void Start() {
        if (instance != null)
        {
            Debug.LogError("Duplicate");

        }
        instance = this;
        Debug.Log("make variable");

       
    
    
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.T)&& Time.timeScale==0)
        {
            
            Application.LoadLevel(Application.loadedLevel);
            Time.timeScale = 1;

        }
    }


}
