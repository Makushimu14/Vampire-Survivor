using UnityEngine;

public class ChangeGround : MonoBehaviour
{
    public static bool Change = false;
    public Material GrassMaterial = null;
    public Material LavaMaterial = null;
    private bool isGrass = true;

    void Update()
    {
        if (Change)
        {
            changeGroung();
        }
    }

    private void changeGroung()
    {
        // ground = GetComponent<MeshRenderer>();

        if (isGrass)
        {
            foreach (GameObject terrain in Globals.Terrains)
            {
                terrain.GetComponent<MeshRenderer>().material = LavaMaterial;
            }
            //ground.material = LavaMaterial;
        }
        else
        {
            foreach (GameObject terrain in Globals.Terrains)
            {
                terrain.GetComponent<MeshRenderer>().material = GrassMaterial;
            }
            //ground.material = GrassMaterial;
        }

        Change = false;
        isGrass = false;
    }
}