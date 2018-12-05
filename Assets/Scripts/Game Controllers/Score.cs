using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Static gör visst att man kan komma åt det i vilket script som helst...
    public static int score;

    public Text scoreText;

    void Start()
    {
        score = 0;

        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
