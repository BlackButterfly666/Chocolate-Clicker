using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{

	//Script on empty: "Click"
	//Script generates, count and display items (cacao, sugar, milk, cream, butter)

	GameObject ClickEmpty;
	public Upgrade upgrade;

	#region Clicked Level 1

	public string itemCacao = "Cacao";      //item name Cacao
	public float cacaoCount;                //generated Cacao
	public int cacaoPerClick = 1;           //generate Cacao amount per Click
	public Text displayCacao;               //text on button with amount of Cacao: #cacaoCount

	public string itemSugar = "Sugar";     //item name Sugar
	public float sugarCount;               //generated Sugar
	public int sugarPerClick = 1;          //generate Sugar amount per Click
	public Text displaySugar;              //text on button with amount of Sugar: #sugarCount

	public string itemMilk = "Milk";       //item name Milk
	public float milkCount;                //generated Milk
	public int milkPerClick = 1;           //generate Milk amount per Click
	public Text displayMilk;               //text on button with amount of Milk: #milkCount

	public string itemCream = "Cream";     //item name Cream
	public float creamCount;               //generated Cream
	public int creamPerClick = 1;          //generate Cream amount per Click
	public Text displayCream;              //text on button with amount of Cream: #creamCount

	public string itemButter = "Butter";   //item name Butter
	public float butterCount;              //generated Butter
	public int butterPerClick = 1;         //generate Butter amount per Click
	public Text displayButter;             //text on button with amount of Butter: #butterCount

	public void ClickedKakao()
	{
		cacaoCount += cacaoPerClick;
	}

	public void ClickedSugar()
	{
		sugarCount += sugarPerClick;
	}

	public void ClickedMilk()
	{
		milkCount += milkPerClick;
	}

	public void ClickedCream()
	{
		creamCount += creamPerClick;
	}

	public void ClickedButter()
	{
		butterCount += butterPerClick;
	}

	#endregion

}
