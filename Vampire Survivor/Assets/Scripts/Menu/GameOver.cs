using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI Text = null;

    // Start is called before the first frame update
    void Start()
    {
        if (GlobalsMenu.Instance.IsGameOver)
        {
            Text.text = "GAME OVER";
        }
    }
}