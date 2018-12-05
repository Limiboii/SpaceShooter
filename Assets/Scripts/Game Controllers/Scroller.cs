using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    //Bakgrunden som rör sig.
    private float scalar = 1f;
    private Material mat;
    
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
    
    void Update()
    {
        mat.mainTextureOffset = new Vector2(Time.time * scalar, 0);
        
    }
}
