using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_remains : MonoBehaviour {

private static audio_remains instance = null;
public static audio_remains Instance {
     
     get { return instance; }
 }

 void Awake() {

     if(instance != null && instance != this)
     {
        Destroy(this.gameObject);
        return;
     }
     else 
     {
        instance = this;
     };

     DontDestroyOnLoad(this.gameObject);
 }
}