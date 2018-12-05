using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    public Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }
    void Update()
    {
        scoreText.text = "You got " + Score.score + " points in total!";
    }
}
