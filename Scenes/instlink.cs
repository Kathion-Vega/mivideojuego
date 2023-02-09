using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instlink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #if !UNITY EDITOR
        openWindow("https://www.instagram.com/");
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
