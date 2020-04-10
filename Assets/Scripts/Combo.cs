using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class Combo : MonoBehaviour
{

    public float fireRate = 2;
    public string[] comboParams;
    public int comboIndex = 0;
    public Animator myanim;
    public float resetTimer;

    // Start is called before the first frame update
    void Start()
    {
        if (comboParams == null || (comboParams != null && comboParams.Length == 0))
        {
            comboParams = new string[] { "Attack1", "Attack2", "Attack3" };
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CnInputManager.GetButtonDown("Atk") && comboIndex < comboParams.Length)
        {
            myanim.SetTrigger(comboParams[comboIndex]);
            comboIndex++;
            resetTimer = 0;
        }

        if(comboIndex > 0)
        {
            resetTimer += Time.deltaTime;
            if(resetTimer >= fireRate)
            {
                myanim.SetTrigger("Reset");
                comboIndex = 0;
            }
        }
    }
}
