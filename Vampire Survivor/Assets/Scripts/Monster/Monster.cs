using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody body = null;

    private Transform player = null;


    void Start()
    {
        GameObject playerGO = GameObject.FindGameObjectWithTag("Player");
        player = playerGO.transform;
    }

    void Update()
    {
        Vector3 playerDirection = player.position - transform.position;
        playerDirection.y = 0;
        playerDirection = playerDirection.normalized;
        body.velocity = new Vector3(playerDirection.x * speed, body.velocity.y, playerDirection.z * speed);

        Vector3 playerSameHeight = player.position;
        playerSameHeight.y = transform.position.y;
        transform.LookAt(playerSameHeight);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
