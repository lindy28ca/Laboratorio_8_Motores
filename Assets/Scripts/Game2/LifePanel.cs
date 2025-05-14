using TMPro;
using UnityEngine;

public class LifePanel : MonoBehaviour
{
    [SerializeField] private TMP_Text life;

    private void OnEnable()
    {
        GameManager.Instance.OnLifeUpdate += OnLifeUpdate;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnLifeUpdate -= OnLifeUpdate;
    }
    private void OnLifeUpdate(int lifeCount)
    {
        life.text = lifeCount.ToString();
    }
}
