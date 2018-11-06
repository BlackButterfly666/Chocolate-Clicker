using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	//Dieses Script hat keinen Nutzen im Spiel. 
	//Es dient lediglich dazu Variablen und deren Ausgabe zu testen.
	//Es bedient das GameObjects "Test" und die beiden Childs (Buttons) "Kakao" und "Mathe"

	public float upgradeCost;
	public float priceMilk;
	public float moneyDark;
	public float moneyMilk;
	public float money;
	
	void Start () {
		
	}
	
	void Update () {
		
	}

	public void MatheDark()
	{
		upgradeCost = Mathf.Round(upgradeCost *= 1.15f);
	}

	public void MatheMilk()
	{
		priceMilk = Mathf.Round(priceMilk * 1.15f);
		moneyMilk = priceMilk;
		money += moneyMilk;
	}
}

