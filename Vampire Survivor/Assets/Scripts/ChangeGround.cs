using UnityEngine;

public class ChangeGround : MonoBehaviour
{
    public static bool Change = true;
    public Material GrassMaterial = null;
    public Material LavaMaterial = null;
    private MeshRenderer ground;
    private bool isGrass = true;

    public void Start()
    {
        if (Change)
        {
            changeGroung();
        }
    }

    public void changeGroung()
    {
        ground = GetComponent<MeshRenderer>();

        if (isGrass)
        {
            ground.material = LavaMaterial;
        }
        else
        {
            ground.material = GrassMaterial;
        }

        Change = false;
        isGrass = false;
    }
}