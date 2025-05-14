using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private int playerLife;
    [SerializeField] private int playerCoins;

    public event Action<int> OnLifeUpdate;
    public event Action<int> OnCoinUpdate;
    public event Action OnWin;
    public event Action OnLoose;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void GainCoin()
    {
        playerCoins++;
        OnCoinUpdate?.Invoke(playerCoins);
        CheckWin();
    }

    public void ModifyLife(int modify)
    {
        playerLife += modify;
        ValidateLife();
        OnLifeUpdate?.Invoke(playerLife);
    }

    public void CheckWin()
    {
        if (playerCoins >= 10) 
        {
            OnWin?.Invoke();
        }
    }
    private void ValidateLife()
    {
        if (playerLife <= 0)
        {
            playerLife = 0;
            OnLoose?.Invoke();
        }
    }
}
