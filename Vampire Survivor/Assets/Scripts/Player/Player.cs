using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Player : Singleton<Player>
{

    public float Speed = 3.0f;
    public int HP = 100;
    public int EXP = 0;
    public static int Level = 0;
    public int Power = 50;
    public bool EnVie = true;
    public Slider ProgressBar = null;
    public TextMeshProUGUI HPText = null;

    private void increaseLevel()
    {
        Level++;
        Globals.Instance.UILevel.enabled = false;
        Globals.Instance.UIBonus.enabled = true;

        Time.timeScale = 0f;

        if (Level > 1 && Level % 10 == 0)
        {
            ChangeGround.Instance.Change(TerrainTexture.LAVA);
            MonsterSpawner.spwanBoss = true;
        }
        if(Level > 1 &&  Level % 10 == 1)
        {
            ChangeGround.Instance.Change(TerrainTexture.GRASS);
        }
    }

    public void IncreaseSpeed()
    {
        Speed += 1.0f;
    }

    public void IncreaseEXP(int exp)
    {
        EXP += exp;

        if(EXP >= 200 + 200 * Level)
        {
            EXP -= (200 + 200 * Level);
            increaseLevel();
        }

        ProgressBar.value = Globals.Instance.GetPourcentage(EXP, 200 + 200 * Level);
    }

    public void IncreasePower()
    {
        Power += 5;
    }

    public void DecreaseHP(int hp)
    {
        HP -= hp;

        if (HP <= 0)
        {
            EnVie = false;
        }

        HPText.text = HP.ToString();
    }

    public void IncreaseHP()
    {
        HP += 50;

        HPText.text = HP.ToString();
    }

    public void ResetPerf()
    {
        Speed = 3.0f;
        HP = 100;
        EXP = 0;
        Level = 0;
        Power = 50;
        EnVie = true;
    }
}