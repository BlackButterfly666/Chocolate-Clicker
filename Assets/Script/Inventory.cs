using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
	GameObject ClickEmpty;
	public Click Click;
	public Recipe Recipe;
	public Sellout Sellout;
	public Upgrade Upgrade;
	
	public Text inventory;

	public void Update()
	{
		ClickTextUpdate();
		RecipeTextUpdate();
		SelloutTextUpdate();
		UpgradeTextUpdate();
		InventoryTextUpdate();
	}
	public void ClickTextUpdate()
	{
		Click.displayCacao.text = Click.itemCacao + "\n" + Click.cacaoCount;
		Click.displaySugar.text = Click.itemSugar + "\n" + Click.sugarCount;
		Click.displayMilk.text = Click.itemMilk + "\n" + Click.milkCount;
		Click.displayCream.text = Click.itemCream + "\n" + Click.creamCount;
		Click.displayButter.text = Click.itemButter + "\n" + Click.butterCount;
	}

	public void RecipeTextUpdate()
	{
		Recipe.displayDarkChocolate.text = Recipe.itemDarkChocolate + " " + Recipe.countDarkChocolate + "\n Cost: Cacao " + Recipe.costCacaoDark + " and Sugar " + Recipe.costSugarDark;
		Recipe.displayMilkChocolate.text = Recipe.itemMilkChocolate + " " + Recipe.countMilkChocolate + "\n Cost: Cacao " + Recipe.costCacaoMilk + ", Sugar " + Recipe.costSugarMilk + " and Milk " + Recipe.costMilkMilk;
		Recipe.displayWhiteChocolate.text = Recipe.itemWhiteChocolate + " " + Recipe.countWhiteChocolate + "\n Cost: Butter " + Recipe.costButterWhite + " and Sugar " + Recipe.costSugarWhite;
		Recipe.displayMilkcreme.text = Recipe.itemMilkcreme + " " + Recipe.countMilkcreme + "\n Cost: Cacao " + Recipe.costCacaoCreme + ", Sugar " + Recipe.costSugarCreme + ", Cream " + Recipe.costCreamCreme + " and Butter " + Recipe.costButterCreme;
		Recipe.displayChocolateMousse.text = Recipe.itemChocolateMousse + " " + Recipe.countChocolateMousse + "\n Cost: Cacao " + Recipe.costCacaoMousse + ", Sugar " + Recipe.costSugarMousse + ", Cream " + Recipe.costCreamMousse + " and Butter " + Recipe.costButterMousse;
	}

	public void SelloutTextUpdate()
	{
		Sellout.darkPrice.text = Sellout.priceDark + "$";
		Sellout.milkPrice.text = Sellout.priceMilk + "$";
		Sellout.whitePrice.text = Sellout.priceWhite + "$";
		Sellout.cremePrice.text = Sellout.priceCreme + "$";
		Sellout.moussePrice.text = Sellout.priceMousse + "$";
	}

	public void UpgradeTextUpdate()
	{
		Upgrade.cacaoCollectorText.text = Upgrade.cacaoCollector + " " + Upgrade.cacaoCollectorCount + "\n Price: " + Upgrade.upgradeCostCacao;
		Upgrade.sugarCollectorText.text = Upgrade.sugarCollector + " " + Upgrade.sugarCollectorCount + "\n Price: " + Upgrade.upgradeCostSugar;
		Upgrade.milkCollectorText.text = Upgrade.milkCollector + " " + Upgrade.milkCollectorCount + "\n Price: " + Upgrade.upgradeCostMilk;
		Upgrade.creamCollectorText.text = Upgrade.creamCollector + " " + Upgrade.creamCollectorCount + "\n Price: " + Upgrade.upgradeCostCream;
		Upgrade.butterCollectorText.text = Upgrade.butterCollector + " " + Upgrade.butterCollectorCount + "\n Price: " + Upgrade.upgradeCostButter;
	}

	public void InventoryTextUpdate()
	{
		inventory.text = "Cacao per Click: " + Click.cacaoPerClick + "\n Sugar per Click: " + Click.sugarPerClick + "\n Milk per Click: " + Click.milkPerClick + "\n Cream per Click: " + Click.creamPerClick + "\n Butter per Click: " + Click.butterPerClick + "\n \n \n Money: " + Sellout.money;
	}
}
