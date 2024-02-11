using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Player Player = null;
    public Button HomeButton;
    public Button RestartButton;

    // Start is called before the first frame update
    void Start()
    {
        Button homeButton = HomeButton.GetComponent<Button>();
        homeButton.onClick.AddListener(goToHome);

        Button restartButton = RestartButton.GetComponent<Button>();
        restartButton.onClick.AddListener(restart);
    }

    private void goToHome()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }

    private void restart()
    {
        SceneManager.LoadScene("LevelScene");
        Time.timeScale = 1f;
    }
}