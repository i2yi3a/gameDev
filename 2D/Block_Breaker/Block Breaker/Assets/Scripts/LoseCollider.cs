using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameOverScene();
    }

    public void gameOverScene()
    {
        SceneManager.LoadScene("3_Game Over");
    }
}
