using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    // Start is called before the first frame update
    void StartGame()
    {
        SceneManager.LoadScene("../primerescenario");
    }

  
}
