using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI Text = null;

    // Start is called before the first frame update
    void Start()
    {
        if (Globals.Instance != null && Globals.Instance.IsGameOver)
        {
            Text.text = "GAME OVER";
        }
    }
}