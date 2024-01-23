using System.Collections.Generic;
using UnityEngine;

public class Globals : Singleton<Globals>
{
    public static List<GameObject> Terrains = new List<GameObject>();
    public static float MaxX = 0.0f;
    public static float MaxY = 0.0f;
    public static float MinX = 0.0f;
    public static float MinY = 0.0f;

    // Update is called once per frame
    void Update()
    {

    }

    public static void AddTerrain(GameObject terrain)
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
        if (terrain.GetComponent<Transform>().position.y > MaxY)
        {
            MaxY = terrain.GetComponent<Transform>().position.y;
        }
        if (terrain.GetComponent<Transform>().position.y < MinY)
        {
            MinY = terrain.GetComponent<Transform>().position.y;
        }
    }
}