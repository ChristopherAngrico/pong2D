using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public GameObject Fading;
    
    public void FadingOut() {
        Fading.SetActive(false);
    }
}
