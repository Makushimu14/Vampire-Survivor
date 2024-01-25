using UnityEngine;
using UnityEngine.UI;

public class BonusChoise : MonoBehaviour
{
    public Player Player = null;
    public Button HPButton;
    public Button PowerButton;
    public Button SpeedButton;

    // Start is called before the first frame update
    void Start()
    {
        Button hpButton = HPButton.GetComponent<Button>();
        hpButton.onClick.AddListener(IncreaseHPPressed);

        Button powerButton = PowerButton.GetComponent<Button>();
        powerButton.onClick.AddListener(IncreasePowerPressed);

        Button speedButton = SpeedButton.GetComponent<Button>();
        speedButton.onClick.AddListener(IncreaseSpeedPressed);
    }

    public void IncreaseHPPressed()
    {
        Player.IncreaseHP();
        continueGame();
    }

    public void IncreasePowerPressed()
    {
        Player.IncreasePower();
        continueGame();
    }

    public void IncreaseSpeedPressed()
    {
        Player.IncreaseSpeed();
        continueGame();
    }

    private void continueGame()
    {
        Globals.Instance.UILevel.enabled = true;
        Globals.Instance.UIBonus.enabled = false;
        Time.timeScale = 1.0f;
    }
}
