using UnityEngine;

public class ChangeGround : Singleton<ChangeGround>
{
    public Material GrassMaterial = null;
    public Material LavaMaterial = null;


    public void Change(TerrainTexture texture)
    {
        if (texture == TerrainTexture.LAVA)
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
    }
}