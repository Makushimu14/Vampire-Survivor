using UnityEngine;

public class OnScreenClicked : MonoBehaviour
{
    public Player Player = null;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject objetTouche = hit.collider.gameObject;

                if (objetTouche.CompareTag("Monster") && Time.timeScale != 0f)
                {
                    Monster monstre = objetTouche.GetComponent<Monster>();
                    if (monstre != null && Player != null)
                    {
                        monstre.DecreaseHP(Player.Power);
                        Player.IncreaseEXP(Player.Power);
                    }
                }
            }
        }
    }
}