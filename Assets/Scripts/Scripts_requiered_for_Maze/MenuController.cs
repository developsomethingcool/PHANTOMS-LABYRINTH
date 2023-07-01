using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject options;
    public GameObject gameoverMenu;
    public GameObject victoryMenu;

    private void Start()
    {
        if(LoadingSettings.showRespawnMenu == "gameoverMenu")
        {
            ShowGameoverMenu();
        } else if (LoadingSettings.showRespawnMenu == "victoryMenu")
        {
            ShowVictoryMenu();
        }
        else
        {
            ShowMainMenu();
        }
       
    }

    public void PlayGame()
    {
        Debug.Log("Inside of player menu!!!!!!!!!!!!!!!!!!!");
        SceneManager.LoadScene("Gameplay");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void RestartGame()
    {
        Debug.Log("Inside of player menu!!!!!!!!!!!!!!!!!!!");
        SceneManager.LoadScene("Gameplay");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ShowMainMenu()
    {
        DisableAllMenus();
        mainMenu.SetActive(true);
    }

    public void ShowOptions()
    {
        DisableAllMenus();
        options.SetActive(true);
    }

    public void ShowGameoverMenu()
    {
        DisableAllMenus();
        gameoverMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void ShowVictoryMenu()
    {
        DisableAllMenus();
        victoryMenu.SetActive(true);
    }

    private void DisableAllMenus()
    {
        mainMenu.SetActive(false);
        options.SetActive(false);
        gameoverMenu.SetActive(false);
        victoryMenu.SetActive(false);
    }

}