using UnityEngine;

public class GenerateGround : MonoBehaviour
{
    public GameObject terrain = null;

    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 playerPosition = player.transform.position;
        Vector3 spawnPosition = new Vector3(playerPosition.x, 0f, playerPosition.z);

        if(terrain != null)
        {
            GameObject spawnedTerrain = Instantiate(terrain, spawnPosition, Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
