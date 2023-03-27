using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using UnityEngine.UI;



public class FirebaseDB : MonoBehaviour
{
    DatabaseReference reference;
    string LED1txt;
    string LED1lectura;

    public Text LED1public;
    // Start is called before the first frame update
    void Start()
    {
        reference = FirebaseDatabase.DefaultInstance.RootReference;
     
    }

    public void BtnON() {
   LED1txt = "ON";
        reference.Child("DB1").Child("LED1").SetValueAsync(LED1txt).ContinueWith(task => {}
        
        );}
    // Update is called once per frame
    public void BtnOFF()
    {
         LED1txt = "OFF";
        reference.Child("DB1").Child("LED1").SetValueAsync(LED1txt).ContinueWith(task => {
     
        });
    }

       void Update()
    {
       
        reference.Child("DB1").Child("LED1").GetValueAsync().ContinueWith(task => {
            DataSnapshot snapshot = task.Result;
            LED1lectura = snapshot.Value.ToString();
        });
        LED1public.text=LED1lectura;
    }
}
