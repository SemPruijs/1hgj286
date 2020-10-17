using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public State state;
    private static GameManager _instance;
         public static GameManager Instance {
         get {
             return _instance;
         }
    }
    private void Awake()
    {
         if (_instance != null && _instance != this)
         {
            Destroy(this.gameObject);
         } else {
            _instance = this;
         } 
    }

    public enum State
    {
        InGame,
        Menu,
        PlayAgain,
        Credit,
        Settings,
        Pause
    };

    void Start()
    {
        Menu();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadCurrentScene();
        }
    }

    public void Menu()
    {
        state = State.Menu;
        DisplayManager.Instance.UpdateUi();
    }

    public void InGame()
    {
        state = State.InGame;
        DisplayManager.Instance.UpdateUi();
    }

    public void Credit()
    {
        state = State.Credit;
        DisplayManager.Instance.UpdateUi();
    }

    public void Settings()
    {
        state = State.Settings;
        DisplayManager.Instance.UpdateUi();
    }

    public void PlayAgain()
    {
        state = State.PlayAgain;
        DisplayManager.Instance.UpdateUi();
    }

    public void Pause()
    {
        state = State.Pause;
        DisplayManager.Instance.UpdateUi();
    }
    
    public void ReloadCurrentScene() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RemoveAllObjectsWithTag(string tag)
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag (tag);

        foreach (var g in gameObjects)
        {
            Destroy(g);
        }
    }
}
