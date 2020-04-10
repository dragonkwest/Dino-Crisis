//
//ShopControlScript.cs for unity-chan!
//
//Original Script is here:
//ricopin / ShopControlScript.cs
//Rocket Jump : http://rocketjump.skr.jp/unity3d/109/
//https://twitter.com/ricopin416
//
//Revised by N.Kobayashi 2014/06/20
//Anima2D adaptation by Mandarina Games 2016/03/18
//
using UnityEngine;
using UnityEngine.UI;

public class ShopControlScript : MonoBehaviour
{
    int coinCount;
    int isSkinSold;

    public Text coinText;
    public Text skinPrice;

    public Button buyButton;

    // Start is called before the first frame update
    void Start()
    {
        coinCount = PlayerPrefs.GetInt ("coinCount");
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coinCount.ToString() + "$";

        isSkinSold = PlayerPrefs.GetInt("isSkinSold");

        if (coinCount >= 1 && isSkinSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;
    }

    public void buySkin()
    {
        coinCount -= 1;
        PlayerPrefs.SetInt("isSkinSold", 1);
        skinPrice.text = "Sold!";
        buyButton.gameObject.SetActive(false);
    }
    }
