using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject Monster1 = null;
    public GameObject Monster2 = null;
    public GameObject Monster3 = null;
    public GameObject Boss1 = null;
    public GameObject Boss2 = null;

    public static bool spwanBoss = false;

    // Start is called before the first frame update
    void Start()
    {
        Globals.Instance.ClearMonster();
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.Instance.Monsters.Count < 100 + Player.Level * 20)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(Globals.MinX, Globals.MaxX), 1, Random.Range(Globals.MinZ, Globals.MaxZ));
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (spawnPosition.x == player.transform.position.x && spawnPosition.x == player.transform.position.z)
            {
                spawnPosition.x += 100;
            }

            GameObject monster;
            int monsterType = Random.Range(1, 3);

            switch (monsterType)
            {
                case 1:
                    monster = Instantiate(Monster1, spawnPosition, Quaternion.identity);
                    break;
                case 2:
                    monster = Instantiate(Monster2, spawnPosition, Quaternion.identity);
                    break;
                case 3:
                    monster = Instantiate(Monster3, spawnPosition, Quaternion.identity);
                    break;
                default:
                    monster = Instantiate(Monster1, spawnPosition, Quaternion.identity);
                    break;
            }

            Globals.Instance.AddMonster(monster);
        }

        if (spwanBoss)
        {
            SpwanBoss();
        }
    }

    void SpwanBoss()
    {
        for (int i = 0; i < Player.Level; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(Globals.MinX, Globals.MaxX), 1, Random.Range(Globals.MinZ, Globals.MaxZ));
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (spawnPosition.x == player.transform.position.x && spawnPosition.x == player.transform.position.z)
            {
                spawnPosition.x += 100;
            }

            Instantiate(Boss1, spawnPosition, Quaternion.identity);

            spawnPosition = new Vector3(Random.Range(Globals.MinX, Globals.MaxX), 1, Random.Range(Globals.MinZ, Globals.MaxZ));
            if (spawnPosition.x == player.transform.position.x && spawnPosition.x == player.transform.position.z)
            {
                spawnPosition.x += 100;
            }
            Instantiate(Boss2, spawnPosition, Quaternion.identity);

            spwanBoss = false;
        }
    }
}