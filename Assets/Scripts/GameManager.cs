using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoSingleton<GameManager>
{
    private bool isGameEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public void EndGame()
    {
        if (isGameEnded)
            return;

        isGameEnded = true;

        rotator.enabled = false ;
        spawner.enabled = false ;

        animator.SetTrigger("EndGame");
        //Debug.Log("END GAME");

        Invoke("RestartLevel", 0.5f);
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
