using System.Collections.Generic;
using UnityEngine;

public class Globals : Singleton<Globals>
{
    public List<GameObject> Terrains = new List<GameObject>();
    public static float MaxX = 0.0f;
    public static float MaxZ = 0.0f;
    public static float MinX = 0.0f;
    public static float MinZ = 0.0f;

    public void AddTerrain(GameObject terrain)
    {
        Terrains.Add(terrain);

        if (terrain.GetComponent<Transform>().position.x > MaxX)
        {
            MaxX = terrain.GetComponent<Transform>().position.x;
        }
        if (terrain.GetComponent<Transform>().position.x < MinX)
        {
            MinX = terrain.GetComponent<Transform>().position.x;
        }
        if (terrain.GetComponent<Transform>().position.z > MaxZ)
        {
            MaxZ = terrain.GetComponent<Transform>().position.z;
        }
        if (terrain.GetComponent<Transform>().position.z < MinZ)
        {
            MinZ = terrain.GetComponent<Transform>().position.z;
        }
    }

    public Vector3 getNewPosition(Vector3 terrainPosition)
    {
        Vector3 result = new Vector3();
        result.x = (int)terrainPosition.x / 500;
        result.x = result.x * 500;
        result.y = 0f;
        result.z = (int)terrainPosition.z / 500;
        result.z = result.z * 500;
        return result;
    }

    public bool TerrainAlreadyExist(Vector3 positions)
    {
        foreach(GameObject terrain in Terrains) {
            
            if(terrain.transform.position.x == positions.x && terrain.transform.position.z == positions.z)
            {
                return true;
            }
        }

        return false;
    }
}