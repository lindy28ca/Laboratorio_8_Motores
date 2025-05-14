using TMPro;
using UnityEngine;

public class CoinPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text coins;

    private void Start()
    {
        GameManager.Instance.OnCoinUpdate += OnCoinUpdate;
    }

    private void OnDestroy()
    {
        GameManager.Instance.OnCoinUpdate -= OnCoinUpdate;
    }

    private void OnCoinUpdate(int coinCount)
    {
        coins.text = coinCount.ToString();
    }
}
