using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalsMenu : MonoBehaviour
{
    private static GlobalsMenu instance = null;

    public static GlobalsMenu Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GlobalsMenu>();

                if (instance == null)
                {
                    GameObject go = new GameObject("GlobalsMenu");
                    instance = go.AddComponent<GlobalsMenu>();
                    DontDestroyOnLoad(go);

                }
            }

            return instance;
        }
    }

    public bool IsGameOver = false;
}
