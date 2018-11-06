using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBase
{

	public Sellout Sellout;
	public ClickPerSecond cps;
	public float upgradeCost;
	public float collectorCount;
		
	public void UpgradeItems()
	{
		if (Sellout.money >= upgradeCost)
		{
			Sellout.money -= upgradeCost;
			collectorCount += 1;
			upgradeCost = Mathf.Round(upgradeCost *= 1.15f);
			cps.CacaoUpgrade();
		}
	}
}
