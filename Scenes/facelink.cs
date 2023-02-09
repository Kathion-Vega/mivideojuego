using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facelink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #if !UNITY EDITOR
        openWindow("https://www.facebook.com/");
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
