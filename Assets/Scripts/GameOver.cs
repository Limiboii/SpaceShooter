using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject score, health, group;

    public void ChangeUI()
    {
        //Gör så att score och health alltid är active när player inte är död.
        score.SetActive(!EnemyCore.isPlayerDead);
        health.SetActive(!EnemyCore.isPlayerDead);
        group.SetActive(EnemyCore.isPlayerDead);
    }

    private void Update()
    {
        ChangeUI();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        //Startar om scenen och sätter player inte är död så att all text kan komma tillbaka!
        SceneManager.LoadScene("The GAME");
        EnemyCore.isPlayerDead = false;
        score.SetActive(EnemyCore.isPlayerDead);
        health.SetActive(EnemyCore.isPlayerDead);
        group.SetActive(!EnemyCore.isPlayerDead);
    }
}
