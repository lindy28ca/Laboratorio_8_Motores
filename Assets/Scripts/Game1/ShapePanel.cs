using UnityEngine;
using UnityEngine.UI;

public class ShapePanel : MonoBehaviour
{
    private Image ColorImage;
    private void Awake()
    {
       ColorImage = GetComponent<Image>();
    }
    private void UpdateShape(Sprite newSprite)
    {
        ColorImage.sprite = newSprite;    
    }
    private void OnEnable()
    {
        ShapeObject.OnChangeShape += UpdateShape; 
    }
    private void OnDisable()
    {
        ShapeObject.OnChangeShape -= UpdateShape;
    }
}
