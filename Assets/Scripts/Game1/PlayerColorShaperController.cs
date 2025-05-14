using UnityEngine;

public class PlayerColorShaperController : MonoBehaviour
{
    private ColorShapeData playerData;
    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        SetUp();
    }
    private void SetUp()
    {
        spriteRenderer.color = playerData.color;   
        spriteRenderer.sprite = playerData.sprite;   
    }
    private void UpdateColor(Color newColor)
    {
        spriteRenderer.color=newColor;
    }
    private void UpdateShape(Sprite newSprite)
    {
        spriteRenderer.sprite=newSprite;
    }
    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
        ShapeObject.OnChangeShape += UpdateShape;
    }
    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
        ShapeObject.OnChangeShape -= UpdateShape;
    }
}
