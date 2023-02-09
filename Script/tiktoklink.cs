using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiktoklink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                #if !UnityEngine
        Application.OpenURL("https://www.tiktok.com/es/");
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
