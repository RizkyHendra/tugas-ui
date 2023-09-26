using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
  
    public void SceneGame()
    {
        SceneManager.LoadScene("Game");
    }
}
