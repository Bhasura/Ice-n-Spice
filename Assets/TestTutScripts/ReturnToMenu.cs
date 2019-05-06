using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject settingsPanel;
    public GameObject car;
    public GameObject spawnPoint;
    public GameObject tipPanel;
    public GameObject shootButton;
    public GameObject driverButton;

    public void Start()
    {
        endPanel.SetActive(false);
        settingsPanel.SetActive(false);
        tipPanel.SetActive(false);
        shootButton.SetActive(false);
        driverButton.SetActive(false);
    }
    public void goToMenu()
    {
        resumeScene();
        SceneManager.LoadScene(0);
    }

    public void showSettings()
    {
        settingsPanel.SetActive(true);
        pauseScene();
    }

    public void hideSettings()
    {
        settingsPanel.SetActive(false);
        resumeScene();
    }

    public void respawnButton()
    {
        car.transform.position = spawnPoint.transform.position;
    }

    void pauseScene()
    {
        Time.timeScale = 0f;
    }

    public void resumeScene()
    {
        Time.timeScale = 1f;
    }

    public void closeTip()
    {
        tipPanel.SetActive(false);
        resumeScene();
    }
}
