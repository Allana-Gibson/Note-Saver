using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
           

    }

    public void pic()
    {
        ScreenshotHandler.TakeScreenshot_Static(Screen.width, Screen.height);

    }
}
