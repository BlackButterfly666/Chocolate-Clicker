using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipe : MonoBehaviour
{
	GameObject ClickEmpty;
	public Click Click;

	#region Recipe Level 1

	public string itemDarkChocolate = "Dark Chocolate";
	public float countDarkChocolate;
	public Text displayDarkChocolate;
	public float costCacaoDark;
	float baseCostCacaoDark = 4;
	public float costSugarDark;
	float baseCostSugarDark = 4;

	public string itemMilkChocolate = "Milk Chocolate";
	public float countMilkChocolate;
	public Text displayMilkChocolate;
	public float costCacaoMilk;
	float baseCostCacaoMilk = 4;
	public float costSugarMilk;
	float baseCostSugarMilk = 4;
	public float costMilkMilk;
	float baseCostMilkMilk = 4;

	public string itemWhiteChocolate = "White Chocolate";
	public float countWhiteChocolate;
	public Text displayWhiteChocolate;
	public float costButterWhite;
	float baseCostButterWhite = 4;
	public float costSugarWhite;
	float baseCostSugarWhite = 4;

	public string itemMilkcreme = "Milkcreme";
	public float countMilkcreme;
	public Text displayMilkcreme;
	public float costCacaoCreme;
	float baseCostCacaoCreme = 4;
	public float costSugarCreme;
	float baseCostSugarCreme = 4;
	public float costCreamCreme;
	float baseCostCreamCreme = 4;
	public float costButterCreme;
	float baseCostButterCreme = 4;

	public string itemChocolateMousse = "Chocolate Mousse";
	public float countChocolateMousse;
	public Text displayChocolateMousse;
	public float costCacaoMousse;
	float baseCostCacaoMousse = 4;
	public float costSugarMousse;
	float baseCostSugarMousse = 4;
	public float costCreamMousse;
	float baseCostCreamMousse = 4;
	public float costButterMousse;
	float baseCostButterMousse = 4;

	public void RecipeDarkChocolate()
	{
		if (Click.cacaoCount >= costCacaoDark && Click.sugarCount >= costSugarDark)
		{
			Click.cacaoCount -= costCacaoDark;
			Click.sugarCount -= costSugarDark;

			countDarkChocolate += 1;

			costCacaoDark = Mathf.Round(baseCostCacaoDark * 1.15f);
			baseCostCacaoDark = costCacaoDark;

			costSugarDark = Mathf.Round(baseCostSugarDark * 1.15f);
			baseCostSugarDark = costSugarDark;
		}
	}
	public void RecipeMilkChocolate()
	{
		if (Click.cacaoCount >= costCacaoMilk && Click.sugarCount >= costSugarMilk && Click.milkCount >= costMilkMilk)
		{
			Click.cacaoCount -= costCacaoMilk;
			Click.sugarCount -= costSugarMilk;
			Click.milkCount -= costMilkMilk;

			countMilkChocolate += 1;

			costCacaoMilk = Mathf.Round(baseCostCacaoMilk * 1.15f);
			baseCostCacaoMilk = costCacaoMilk;

			costSugarMilk = Mathf.Round(baseCostSugarMilk * 1.15f);
			baseCostSugarMilk = costSugarMilk;

			costMilkMilk = Mathf.Round(baseCostMilkMilk * 1.15f);
			baseCostMilkMilk = costMilkMilk;
		}
	}
	public void RecipeWhiteChocolate()
	{
		if (Click.butterCount >= costButterWhite && Click.sugarCount >= costSugarWhite)
		{
			Click.butterCount -= costButterWhite;
			Click.sugarCount -= costSugarWhite;

			countWhiteChocolate += 1;

			costButterWhite = Mathf.Round(baseCostButterWhite * 1.15f);
			baseCostButterWhite = costButterWhite;

			costSugarWhite = Mathf.Round(baseCostSugarWhite * 1.15f);
			baseCostSugarWhite = costSugarWhite;
		}
	}
	public void RecipeMilkcreme()
	{
		if (Click.cacaoCount >= costCacaoCreme && Click.butterCount >= costButterCreme && Click.creamCount >= costCreamCreme && Click.sugarCount >= costSugarCreme)
		{
			Click.cacaoCount -= costCacaoCreme;
			Click.butterCount -= costButterCreme;
			Click.creamCount -= costCreamCreme;
			Click.sugarCount -= costSugarCreme;

			countMilkcreme += 1;

			costCacaoCreme = Mathf.Round(baseCostCacaoCreme * 1.15f);
			baseCostCacaoCreme = costCacaoCreme;

			costButterCreme = Mathf.Round(baseCostButterCreme * 1.15f);
			baseCostButterCreme = costButterCreme;

			costCreamCreme = Mathf.Round(baseCostCreamCreme * 1.15f);
			baseCostCreamCreme = costCreamCreme;

			costSugarCreme = Mathf.Round(baseCostSugarCreme * 1.15f);
			baseCostSugarCreme = costSugarCreme;
		}
	}
	public void RecipeChocolateMousse()
	{
		if (Click.cacaoCount >= costCacaoMousse && Click.sugarCount >= costSugarMousse && Click.creamCount >= costCreamMousse && Click.butterCount >= costButterMousse)
		{
			Click.cacaoCount -= costCacaoMousse;
			Click.sugarCount -= costSugarMousse;
			Click.creamCount -= costCreamMousse;
			Click.butterCount -= costButterMousse;

			countChocolateMousse += 1;

			costCacaoMousse = Mathf.Round(baseCostCacaoMousse * 1.15f);
			baseCostCacaoMousse = costCacaoMousse;

			costSugarMousse = Mathf.Round(baseCostSugarMousse * 1.15f);
			baseCostSugarMousse = costSugarMousse;

			costCreamMousse = Mathf.Round(baseCostCreamMousse * 1.15f);
			baseCostCreamMousse = costCreamMousse;

			costButterMousse = Mathf.Round(baseCostButterMousse * 1.15f);
			baseCostButterMousse = costButterMousse;
		}
	}

	#endregion


}
