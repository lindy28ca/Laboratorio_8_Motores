using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    private Image ColorImage;
    private void Awake()
    {
        ColorImage = GetComponent<Image>();
    }
    private void UpdateColor(Color newColor)
    {
        ColorImage.color = newColor;
    }
    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
    }
    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
    }
}
