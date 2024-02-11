using UnityEngine;

public class BonusSpawner: MonoBehaviour
{
    public GameObject Bonus = null;

    void Start()
    {
        Globals.Instance.ClearBonus();
    }

    void Update()
    {
        if (Globals.Instance.Bonus.Count < 100 + Player.Level * 20)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(Globals.MinX, Globals.MaxX), 0.5f, Random.Range(Globals.MinZ, Globals.MaxZ));
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            if (spawnPosition.x == player.transform.position.x && spawnPosition.x == player.transform.position.z)
            {
                spawnPosition.x += 100;
            }

            GameObject bonus = Instantiate(Bonus, spawnPosition, Quaternion.identity);

            Globals.Instance.AddBonus(bonus);
        }
    }
}
