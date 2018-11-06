using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sellout : MonoBehaviour
{
	GameObject ClickEmpty;
	public Recipe Recipe;
	public float money;

	#region Sellout Level 1

	public float priceDark = 5;
	public Text darkPrice;
	public float priceMilk = 5;
	public Text milkPrice;
	public float priceWhite = 5;
	public Text whitePrice;
	public float priceCreme = 5;
	public Text cremePrice;
	public float priceMousse = 5;
	public Text moussePrice;

	public void SellDarkChocolate()
	{
		if (Recipe.countDarkChocolate >= 1)
		{
			Recipe.countDarkChocolate -= 1;
			priceDark = Mathf.Round(priceDark * 1.15f);
			money += priceDark;
		}
	}

	public void SellMilkChocolate()
	{
		if (Recipe.countMilkChocolate >= 1)
		{
			Recipe.countMilkChocolate -= 1;
			priceMilk = Mathf.Round(priceMilk * 1.15f);
			money += priceMilk;
		}
	}

	public void SellWhiteChocolate()
	{
		if (Recipe.countWhiteChocolate >= 1)
		{
			Recipe.countWhiteChocolate -= 1;
			priceWhite = Mathf.Round(priceWhite * 1.15f);
			money += priceWhite;
		}
	}

	public void SellMilkcreme()
	{
		if (Recipe.countMilkcreme >= 1)
		{
			Recipe.countMilkcreme -= 1;
			priceCreme = Mathf.Round(priceCreme * 1.15f);
			money += priceCreme;
		}
	}

	public void SellChocolateMousse()
	{
		if (Recipe.countChocolateMousse >= 1)
		{
			Recipe.countChocolateMousse -= 1;
			priceMousse = Mathf.Round(priceMousse * 1.15f);
			money += priceMousse;
		}
	}

	#endregion

}
