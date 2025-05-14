using System;
using UnityEngine;

public class ColorObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData colorData;
    private SpriteRenderer spriteRenderer;
    public static Action<Color> OnChangeColor;
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
        spriteRenderer.color=colorData.color;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnChangeColor?.Invoke(colorData.color);
        }
    }
}
