using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject startScreen;
    public GameObject gameOverScreen;

    void Start()
    {
        //Aluksi peli kutsuu aloitusruudun funktiota
        ShowStartScreen();
    }

    //Vaihtaa aloitusruudun aktiiviseksi
    public void ShowStartScreen()
    {
        startScreen.SetActive(true);
        gameOverScreen.SetActive(false);
        Time.timeScale = 0;
    }

    //Aloittaa pelin, t‰t‰ kutsutaan kun painetaan start game aloitusruudulta
    public void StartGame()
    {
        startScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        Time.timeScale = 1;
    }

    //N‰ytt‰‰ game over ruudun ja pys‰ytt‰‰ pelin
    public void ShowGameOverScreen()
    {
        startScreen.SetActive(false);
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

    //T‰t‰ kutsutaan kun painetaan restart game nappia game over ruudulla
    public void RestartGame()
    {
        //Peli‰ restartatessaa ladataan koko scene uudelleen 
        //(Toteutus tuskin optimaalinen mutta t‰ll‰ toteutustavalla peli tekee sen mit‰ toivotaan
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Reloading scene...");
    }
}