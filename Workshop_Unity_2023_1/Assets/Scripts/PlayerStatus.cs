using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private int coinsTotal = 0;
    public void CollectCoin()
    {
        coinsTotal++;
    }
}
