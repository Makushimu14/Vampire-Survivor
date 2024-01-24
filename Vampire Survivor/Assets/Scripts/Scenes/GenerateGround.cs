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
            Debug.LogWarning("Il y a d�j� une instance de PrefabManager. La nouvelle instance sera d�truite.");
            Destroy(this.gameObject);
        }


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
                GameObject terrainCopy1 = Instantiate(terrain);
                terrainCopy1.GetComponent<MeshRenderer>().material = Globals.Instance.Terrains.First().GetComponent<MeshRenderer>().sharedMaterial;
                Instantiate(terrainCopy1, spawnPosition, Quaternion.identity);
                terrainCopy1.transform.position = spawnPosition;
                Debug.Log("Position du terrain: " + terrainCopy1.transform.position.x + ", " + terrainCopy1.transform.position.z);
                Debug.Log("Position du spawnPosition: " + spawnPosition.x + ", " + spawnPosition.z);
                Globals.Instance.AddTerrain(terrainCopy1);
            }

            playerPosition.x -= 1000;

            spawnPosition = Globals.Instance.getNewPosition(playerPosition);
            if (!Globals.Instance.TerrainAlreadyExist(spawnPosition))
            {
                GameObject terrainCopy2 = Instantiate(terrain);
                terrainCopy2.GetComponent<MeshRenderer>().material = Globals.Instance.Terrains.First().GetComponent<MeshRenderer>().sharedMaterial;
                Instantiate(terrainCopy2, spawnPosition, Quaternion.identity);
                terrainCopy2.transform.position = spawnPosition;
                Debug.Log("Position du terrain: " + terrainCopy2.transform.position.x + ", " + terrainCopy2.transform.position.z);
                Debug.Log("Position du spawnPosition: " + spawnPosition.x + ", " + spawnPosition.z);
                Globals.Instance.AddTerrain(terrainCopy2);
            }

            playerPosition.x += 500;
            playerPosition.z += 500;

            spawnPosition = Globals.Instance.getNewPosition(playerPosition);
            if (!Globals.Instance.TerrainAlreadyExist(spawnPosition))
            {
                GameObject terrainCopy3 = Instantiate(terrain);
                terrainCopy3.GetComponent<MeshRenderer>().material = Globals.Instance.Terrains.First().GetComponent<MeshRenderer>().sharedMaterial;
                Instantiate(terrainCopy3, spawnPosition, Quaternion.identity);
                terrainCopy3.transform.position = spawnPosition;
                Debug.Log("Position du terrain: " + terrainCopy3.transform.position.x + ", " + terrainCopy3.transform.position.z);
                Debug.Log("Position du spawnPosition: " + spawnPosition.x + ", " + spawnPosition.z);
                Globals.Instance.AddTerrain(terrainCopy3);
            }

            playerPosition.z -= 1000;

            spawnPosition = Globals.Instance.getNewPosition(playerPosition);
            if (!Globals.Instance.TerrainAlreadyExist(spawnPosition))
            {
                GameObject terrainCopy4 = Instantiate(terrain);
                terrainCopy4.GetComponent<MeshRenderer>().material = Globals.Instance.Terrains.First().GetComponent<MeshRenderer>().sharedMaterial;
                Instantiate(terrainCopy4, spawnPosition, Quaternion.identity);
                terrainCopy4.transform.position = spawnPosition;
                Debug.Log("Position du terrain: " + terrainCopy4.transform.position.x + ", " + terrainCopy4.transform.position.z);
                Debug.Log("Position du spawnPosition: " + spawnPosition.x + ", " + spawnPosition.z);
                Globals.Instance.AddTerrain(terrainCopy4);
            }
        }
    }
}
