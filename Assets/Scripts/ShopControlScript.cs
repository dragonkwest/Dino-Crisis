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
    int isSkinRedSold;
    int isSkinBlueSold;

    public Text coinText;
    public Text skinPrice;
    public Text skinPrice2;

    public Button buyButton;
    public Button buyButton2;


    // Start is called before the first frame update
    void Start()
    {
        coinCount = PlayerPrefs.GetInt ("coinCount");
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coinCount.ToString() + "$";

        isSkinRedSold = PlayerPrefs.GetInt("isRedSkinSold");
        isSkinBlueSold = PlayerPrefs.GetInt("isBlueSkinSold");

        if (coinCount >= 1 && isSkinRedSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;

        if (coinCount >= 1 && isSkinBlueSold == 0)
            buyButton2.interactable = true;
        else
            buyButton2.interactable = false;
    }

    public void buyRedSkin()
    {
        coinCount -= 1;
        PlayerPrefs.SetInt("isRedSkinSold", 1);
        skinPrice.text = "Sold!";
        buyButton.gameObject.SetActive(false);
    }

    public void buyBlueSkin()
    {
        coinCount -= 1;
        PlayerPrefs.SetInt("isBlueSkinSold", 1);
        skinPrice2.text = "Sold!";
        buyButton.gameObject.SetActive(false);
    }

}


