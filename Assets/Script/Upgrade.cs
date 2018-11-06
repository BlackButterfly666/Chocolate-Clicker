using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
	GameObject ClickEmpty;
	public Click Click;
	public Sellout Sellout;
	public ClickPerSecond cps;

	#region Upgrade Level 1

	public string cacaoCollector = "Cacao Collector";
	public float cacaoCollectorCount = 0;
	public float upgradeCostCacao = 100;
	public Text cacaoCollectorText;

	public string sugarCollector = "Cuting Machine";
	public float sugarCollectorCount = 0;
	public float upgradeCostSugar = 100;
	public Text sugarCollectorText;

	public string milkCollector = "Dairy Plant";
	public float milkCollectorCount = 0;
	public float upgradeCostMilk = 100;
	public Text milkCollectorText;

	public string creamCollector = "Stirring Machine";
	public float creamCollectorCount = 0;
	public float upgradeCostCream = 100;
	public Text creamCollectorText;

	public string butterCollector = "Butter Tamper";
	public float butterCollectorCount = 0;
	public float upgradeCostButter = 100;
	public Text butterCollectorText;

	public void UpgradeCacao()
	{
		if (Sellout.money >= upgradeCostCacao)
		{
			Sellout.money -= upgradeCostCacao;
			cacaoCollectorCount += 1;
			upgradeCostCacao = Mathf.Round(upgradeCostCacao *= 1.15f);
			cps.CacaoUpgrade();
		}
	}

	public void UpgradeSugar()
	{
		if (Sellout.money >= upgradeCostSugar)
		{
			Sellout.money -= upgradeCostSugar;
			sugarCollectorCount += 1;
			upgradeCostSugar = Mathf.Round(upgradeCostSugar *= 1.15f);
			cps.SugarUpgrade();
		}
	}

	public void UpgradeMilk()
	{
		if (Sellout.money >= upgradeCostMilk)
		{
			Sellout.money -= upgradeCostMilk;
			milkCollectorCount += 1;
			upgradeCostMilk = Mathf.Round(upgradeCostMilk *= 1.15f);
			cps.MilkUpgrade();
		}
	}

	public void UpgradeCream()
	{
		if (Sellout.money >= upgradeCostCream)
		{
			Sellout.money -= upgradeCostCream;
			creamCollectorCount += 1;
			upgradeCostCream = Mathf.Round(upgradeCostCream *= 1.15f);
			cps.CreamUpgrade();
		}
	}

	public void UpgradeButter()
	{
		if (Sellout.money >= upgradeCostButter)
		{
			Sellout.money -= upgradeCostButter;
			butterCollectorCount += 1;
			upgradeCostButter = Mathf.Round(upgradeCostButter *= 1.15f);
			cps.ButterUpgrade();
		}
	}

	#endregion

}
