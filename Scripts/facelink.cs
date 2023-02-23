using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facelink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #if !UnityEngine
        Application.OpenURL("https://www.facebook.com/");
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
