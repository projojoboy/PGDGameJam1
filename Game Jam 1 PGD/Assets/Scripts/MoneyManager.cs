using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    // Start is called before the first frame update

    public int money = 0;

    [SerializeField] private Text moneyText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            money += 50;
        }


        moneyText.text = "Money: " + money;
    }
}
