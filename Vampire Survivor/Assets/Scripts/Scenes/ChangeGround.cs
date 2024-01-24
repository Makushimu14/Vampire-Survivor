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
        if (isGrass)
        {
            foreach (GameObject terrain in Globals.Instance.Terrains)
            {
                terrain.GetComponent<MeshRenderer>().material = LavaMaterial;
            }
        }
        else
        {
            foreach (GameObject terrain in Globals.Instance.Terrains)
            {
                terrain.GetComponent<MeshRenderer>().material = GrassMaterial;
            }
        }

        Change = false;
        isGrass = false;
    }
}