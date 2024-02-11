using System.Linq;
using UnityEngine;

public class GenerateGround : MonoBehaviour 
{ 
    public GameObject terrain = null;
    public static GenerateGround Instance;
    public Material GrassMaterial = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogWarning("Il y a déjà une instance de PrefabManager. La nouvelle instance sera détruite.");
            Destroy(this.gameObject);
        }

        Globals.Instance.ClearTerrains();

        Vector3 spawnPosition = new Vector3(0f, 0f, 0f);
        terrain.transform.position = spawnPosition;
        terrain.GetComponent<MeshRenderer>().material = GrassMaterial;
        Instantiate(terrain, spawnPosition, Quaternion.identity);
        Globals.Instance.AddTerrain(terrain);
    }

    public void Generate()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 playerPosition = player.transform.position;
        
        if (terrain != null)
        {
            Vector3 spawnPosition = playerPosition;
            playerPosition.x += 500;
            
            spawnPosition = Globals.Instance.getNewPosition(playerPosition);
            if (!Globals.Instance.TerrainAlreadyExist(spawnPosition))
            {
                GameObject terrainCopy1 = Instantiate(terrain, spawnPosition, Quaternion.identity); 
                terrainCopy1.transform.position = spawnPosition;
                Globals.Instance.AddTerrain(terrainCopy1);
            }

            playerPosition.x -= 1000;

            spawnPosition = Globals.Instance.getNewPosition(playerPosition);
            if (!Globals.Instance.TerrainAlreadyExist(spawnPosition))
            {
                GameObject terrainCopy2 = Instantiate(terrain, spawnPosition, Quaternion.identity);
                terrainCopy2.transform.position = spawnPosition;
                Globals.Instance.AddTerrain(terrainCopy2);
            }

            playerPosition.x += 500;
            playerPosition.z += 500;

            spawnPosition = Globals.Instance.getNewPosition(playerPosition);
            if (!Globals.Instance.TerrainAlreadyExist(spawnPosition))
            {
                GameObject terrainCopy3 = Instantiate(terrain, spawnPosition, Quaternion.identity);
                terrainCopy3.transform.position = spawnPosition;
                Globals.Instance.AddTerrain(terrainCopy3);
            }

            playerPosition.z -= 1000;

            spawnPosition = Globals.Instance.getNewPosition(playerPosition);
            if (!Globals.Instance.TerrainAlreadyExist(spawnPosition))
            {
                GameObject terrainCopy4 =  Instantiate(terrain, spawnPosition, Quaternion.identity);
                terrainCopy4.transform.position = spawnPosition;
                Globals.Instance.AddTerrain(terrainCopy4);
            }
        }
    }
}
