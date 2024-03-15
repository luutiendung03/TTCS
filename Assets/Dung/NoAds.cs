using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAds : MonoBehaviour
{
    public void BuySGold()
    {
        PlayerPersistentData.Instance.Gold += 5500;
    }
    public void BuyMGold()
    {
        PlayerPersistentData.Instance.Gold += 5000;
    }
    public void BuyLGold()
    {
        PlayerPersistentData.Instance.Gold += 15000;
        PlayerPersistentData.Instance.SetUsedItem(LoadingItem.Skin, 27);
        PlayerPersistentData.Instance.SetUsedItem(LoadingItem.Skin, 28);
        PlayerPersistentData.Instance.SetUsedItem(LoadingItem.Skin, 29);
    }
}
