using UnityEngine;

public class ColorProperty : MonoBehaviour
{
    [SerializeField] protected Color colorData;
    [SerializeField] protected MeshRenderer meshRenderer;
    [SerializeField] protected Material material;
    protected void SetUpColor(ColorData newColor)
    {
        colorData = newColor.color;
        material = new Material(meshRenderer.sharedMaterial);
        material.color = colorData;
        meshRenderer.material = material;
    }
}
