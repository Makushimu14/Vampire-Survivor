public class Player : Singleton<Player>
{

    public static float Speed = 10.0f;
    public int HP = 100;
    public int EXP = 0;
    public int Level = 0;
    public int Power = 10;
    public bool EnVie = true;

    public void Update()
    {
        increaseLevel();
    }
    private void increaseLevel()
    {
        Level++;
        if (Level > 1 && (Level % 10 == 0 || Level % 10 == 1))
        {
            ChangeGround.Change = true;
        }
    }

    public void IncreaseSpeed()
    {
        Speed += 5.0f;
    }

    public void IncreaseEXP(int exp)
    {
        EXP += exp;
        if(EXP > 200)
        {
            EXP -= 200;
            increaseLevel();
        }
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
    }

    public void IncreaseHP()
    {
        HP += 50;
    }
}