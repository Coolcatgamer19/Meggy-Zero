using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_CoinCounter : MonoBehaviour
{
   public Text DogecounterText;
    // Update is called once per frame
    void Update()
    {
        DogecounterText.text = DogecounterText.text = SC_2DCoin.totalDogeCoins.ToString();
    }

    
}
