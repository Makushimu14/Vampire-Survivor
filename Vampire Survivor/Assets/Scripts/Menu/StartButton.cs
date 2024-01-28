using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Button startButton;
    public string LevelToLoad;

    void Start()
    {
        startButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        LoadLevel();
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
