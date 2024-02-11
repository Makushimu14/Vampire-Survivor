using UnityEngine;

public class Bonus : MonoBehaviour
{
    public Rigidbody body = null;
    public GameObject bonus = null;

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            var result = Random.Range(0, 3);

            switch (result)
            {
                case 0:
                    Player.Instance.HP += 10;
                    Player.Instance.HPText.text = Player.Instance.HP.ToString();
                    Globals.Instance.SetBonusText("HP increased !");
                    break;
                case 1:
                    Player.Instance.Power += 10;
                    Globals.Instance.SetBonusText("Power increased !");
                    break;
                case 2:
                    Player.Instance.Speed += 1;
                    Globals.Instance.SetBonusText("Speed increased !");
                    break;
                default:
                    Player.Instance.Speed += 1;
                    Globals.Instance.SetBonusText("Speed increased !");
                    break;
            }

            Globals.Instance.RemoveBonus(bonus);
            Destroy(bonus);
        }
    }
}

public enum TypeBonus
{
    BONUS_HP,
    BONUS_POWER,
    BONUS_SPEED
}