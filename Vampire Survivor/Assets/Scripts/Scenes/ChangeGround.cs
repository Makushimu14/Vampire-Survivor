using UnityEngine;

public class ChangeGround : MonoBehaviour
{
    public static bool Change = false;
    public Material GrassMaterial = null;
    public Material LavaMaterial = null;
    private MeshRenderer ground;
    private bool isGrass = true;

    private void Awake()
    {
        ground = GetComponent<MeshRenderer>();
        ground.material = GrassMaterial;
    }

    void Start()
    {
        ground = GetComponent<MeshRenderer>();

        if (Change)
        {
            changeGroung();
        }
    }

    private void changeGroung()
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