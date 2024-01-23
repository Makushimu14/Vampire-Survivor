using UnityEngine;

public class GenerateGround : Singleton<GenerateGround>
{
    public GameObject terrain = null;

    private void Awake()
    {
        Generate();
    }

    public void Generate()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 playerPosition = player.transform.position;
        Vector3 spawnPosition = new Vector3(playerPosition.x, 0f, playerPosition.z);

        if (terrain != null)
        {
            Instantiate(terrain, spawnPosition, Quaternion.identity);
            Debug.Log("dans generate");
            Globals.AddTerrain(terrain);
            Debug.Log("dans generate nombre:" + Globals.Terrains.Count);
        }
    }
}
