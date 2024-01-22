using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance = null;
    public static T Instance
    { 
        get => instance;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else
        {
            Debug.LogError($"L'instance { GetType() } existe déjà.");
            Destroy(gameObject);
        }
    }
}