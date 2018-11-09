using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject score, health, group;

    public bool NotHappend;
    private void Start()
    {
        NotHappend = true;
    }
    public void ChangeUI()
    {

        score.SetActive(!EnemyCore.isPlayerDead);
        health.SetActive(!EnemyCore.isPlayerDead);
        group.SetActive(EnemyCore.isPlayerDead);
    }

    private void Update()
    {
        ChangeUI();
        /*if (EnemyCore.isPlayerDead && NotHappend)
        {
            NotHappend = false;
        }*/
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("The GAME");
        EnemyCore.isPlayerDead = false;
        score.SetActive(EnemyCore.isPlayerDead);
        health.SetActive(EnemyCore.isPlayerDead);
        group.SetActive(!EnemyCore.isPlayerDead);
        NotHappend = true;
    }
}
