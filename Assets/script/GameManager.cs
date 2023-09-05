using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int sphere;
    public TextMeshProUGUI spheretext;
    public TextMeshProUGUI GameOverText;
    public Button restartButton;
    public GameObject Title;
    public bool isGameActive;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    public void startGame()
    {
        isGameActive = true;
        UpdateSphere(40);
        Title.gameObject.SetActive(false);
    }
    void Update()
    {
        
    }

    public void UpdateSphere(int sphereToAdd)
    {
        spheretext.text = "sphere: " + sphere;
        sphere += sphereToAdd;
    }
    public void GameOver()
    {
        isGameActive = false;
        GameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }
    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
