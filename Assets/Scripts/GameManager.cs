using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PlayerGO;

    public void Start()
    {
        PlayerGO.GetComponent<PlayerController>().Health.OnHealthReachedZero += Die;
        PlayerGO.GetComponent<PlayerController>().GameEnded += GameEnded;
    }

    public void Die()
    {
        Debug.Log("Die");
        // Restart the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameEnded()
    {
        Debug.Log("GameEnded");
        // Restart the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
