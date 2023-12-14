using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinType : MonoBehaviour
{
    private bool goodCoin = true;
    private int lives = 3;
    private bool BadCoin = false;

    private int totalGoodCoinsCollected = 0;

    [SerializeField] private GameObject[] coinPrefabsArray;
    private int coinIndex;

    void CollectCoin()
    {
        if (goodCoin)
        {
            totalGoodCoinsCollected++;
            Debug.Log("Good Coins: " + totalGoodCoinsCollected);
        }
        else if (BadCoin)
        {
            LoseLife();
        }
    }

    void LoseLife()
    {
        lives--;
        Debug.Log("Lives remaining: " + lives);


        if (lives <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
