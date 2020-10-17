using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayManager : MonoBehaviour
{
    private static DisplayManager _instance;
    public static DisplayManager Instance {
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
    
    public GameObject menu;
    public GameObject inGame;
    public GameObject playAgain;
    public GameObject credit;
    public GameObject settings;
    
    public void UpdateUi()
    {
        menu.SetActive(GameManager.Instance.state == GameManager.State.Menu);
        inGame.SetActive(GameManager.Instance.state == GameManager.State.InGame);
        playAgain.SetActive(GameManager.Instance.state == GameManager.State.PlayAgain);
        credit.SetActive(GameManager.Instance.state == GameManager.State.Credit);
        settings.SetActive(GameManager.Instance.state == GameManager.State.Settings);
    }
}
