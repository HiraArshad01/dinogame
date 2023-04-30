using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class mainscenePanel : MonoBehaviour
{
    public GameObject Play;
    public GameObject Howplay;
    public GameObject MainPanel;
    // Start is called before the first frame update
    void Start()
    {
          MainPanel.SetActive(true);
          Howplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void exitGame(){
        Application.Quit();
    }

    public void howToplay(){
        Howplay.SetActive(true);
        MainPanel.SetActive(false);
    }

    public void back(){
        MainPanel.SetActive(true);
        Howplay.SetActive(false);
    }
}
