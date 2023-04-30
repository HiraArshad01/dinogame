using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Panelscript : MonoBehaviour
{


    public GameObject MenuPanel;
    public GameObject AdPanel;
    public AudioSource gameaudio;
    public Button MuteButton;
    public Button UnMuteButton;


    void Start()
    {

        MenuPanel.SetActive(false);
        AdPanel.SetActive(false);
        MuteButton.gameObject.SetActive(true);
        UnMuteButton.gameObject.SetActive(false);
       
    }

    private void Update()
    {

    }


    public void PauseGame()
    {
        Time.timeScale = 0;
        ShowMenuPanel();
        
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        MenuPanel.SetActive(false);
        AdPanel.SetActive(false);
    }

    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
    }

    public void ShowAdPanel()
    {
        AdPanel.SetActive(true);
    }

     
    public void muteGame()
     {
          gameaudio.mute = true;
          MuteButton.gameObject.SetActive(false);
          UnMuteButton.gameObject.SetActive(true);
     }
     public void UnmuteGame()
     {
          gameaudio.mute = false;
          MuteButton.gameObject.SetActive(true);
          UnMuteButton.gameObject.SetActive(false);
     }

    public void Menu()
    {
        SceneManager.LoadScene("mainMenu");
    }

}
