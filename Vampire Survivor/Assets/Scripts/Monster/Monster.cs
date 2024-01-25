using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    public float speed = 5.0f;
    public int Power = 0;
    public Rigidbody body = null;
    public int HP = 0;
    private Transform player = null;
    public GameObject Quad = null;


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
        body.velocity = new Vector3(playerDirection.x * speed, 0, playerDirection.z * speed);

        Vector3 playerSameHeight = player.position;
        playerSameHeight.y = transform.position.y;
        transform.LookAt(playerSameHeight);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Player.Instance.DecreaseHP(Power);
        }
    }

    public void DecreaseHP(int power)
    {
        if(HP - power <= 0)
        {
            Globals.Instance.RemoveMonster(gameObject);
            setQuad();
            Destroy(gameObject);

        }
        else
        {
            HP -= power;
        }
    }

    private void setQuad()
    {
        Quad.transform.position = new Vector3(transform.position.x, 1, transform.position.z);
    }
}
