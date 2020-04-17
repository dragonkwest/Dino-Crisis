//
//ChangeColor.cs for unity-chan!
//
//Original Script is here:
//ricopin / ChangeColor.cs
//Rocket Jump : http://rocketjump.skr.jp/unity3d/109/
//https://twitter.com/ricopin416
//
//Revised by N.Kobayashi 2014/06/20
//Anima2D adaptation by Mandarina Games 2016/03/18
//
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer rend;
    [SerializeField]
    private Color colorToTurnTo = Color.white;
    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<Renderer>();

        rend.material.color = colorToTurnTo;
    }


}
