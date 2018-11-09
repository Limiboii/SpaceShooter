using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public Text healthLeft;

    void Start()
    {
        healthLeft = GetComponent<Text>();
    }
    
    void Update()
    {
        healthLeft.text = "Health Left: " + PlayerHealth.health;
    }
}
