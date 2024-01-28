using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Globals : MonoBehaviour
{
    private static Globals instance = null;

    public static Globals Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Globals>();

                if (instance == null)
                {
                    GameObject go = new GameObject("Globals");
                    instance = go.AddComponent<Globals>();
                    DontDestroyOnLoad(go);
                }
            }

            return instance;
        }
    }

    public Canvas UILevel = null;
    public Canvas UIBonus = null;

    public void Update()
    {
        if ( Player.Instance != null && !Player.Instance.EnVie)
        {
            IsGameOver = true;
            SceneManager.LoadScene("StartMenu");
        }
    }

    #region Menu
    public bool IsGameOver = false;
    #endregion

    #region Terrain
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

    public void ClearTerrains()
    {
        Terrains.Clear();
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
    #endregion

    #region Monster
    public List<GameObject> Monsters = new List<GameObject>();
    public void AddMonster(GameObject monster)
    {
        Monsters.Add(monster);
    }

    public void RemoveMonster(GameObject monster)
    {
        try
        {
            Monsters.Remove(monster);
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
    }

    public void ClearMonster()
    {
        Monsters.Clear();
    }

    #endregion

    public float GetPourcentage(int value, int max)
    {
        float result = value * 100 / max;

        return result;
    }
}

public enum TerrainTexture
{
    GRASS,
    LAVA
}