using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPerSecond : MonoBehaviour
{
	public Click click;

	public float cacaoTimer = 0;
	public float sugarTimer = 0;
	public float milkTimer = 0;
	public float creamTimer = 0;
	public float butterTimer = 0;

	public float cacaoPerSecond = 0;        //generated automatic Cacao Item per Second
	public float sugarPerSecond = 0;        //generated automatic Sugar Item per Second
	public float milkPerSecond = 0;         //generated automatic Milk Item per Second
	public float creamPerSecond = 0;        //generated automatic Cream Item per Second
	public float butterPerSecond = 0;       //generated automatic Butter Item per Second

	//Timer Variablen
	public float timer = 0;
	public float waitTime = 1;


	public void Update()
	{
		ItemPerSecond();
	}

	#region Item Upgrades Level 1

	public void CacaoUpgrade()
	{
		click.cacaoPerClick += 1;
		cacaoTimer += 1;

		if (cacaoTimer == 5)
		{
			cacaoPerSecond += 1;
			cacaoTimer = 0;
		}
	}

	public void SugarUpgrade()
	{
		click.sugarPerClick += 1;
		sugarTimer += 1;

		if (sugarTimer == 5)
		{
			sugarPerSecond += 1;
			sugarTimer = 0;
		}
	}

	public void MilkUpgrade()
	{
		click.milkPerClick += 1;
		milkTimer += 1;

		if (milkTimer == 5)
		{
			milkPerSecond += 1;
			milkTimer = 0;
		}
	}

	public void CreamUpgrade()
	{
		click.creamPerClick += 1;
		creamTimer += 1;

		if (creamTimer == 5)
		{
			creamPerSecond += 1;
			creamTimer = 0;
		}
	}

	public void ButterUpgrade()
	{
		click.butterPerClick += 1;
		butterTimer += 1;

		if (butterTimer == 5)
		{
			butterPerSecond += 1;
			butterTimer = 0;
		}
	}

	#endregion

	public void ItemPerSecond()
	{
		timer += Time.deltaTime;
		if (timer > waitTime)
		{
			click.cacaoCount += cacaoPerSecond;
			click.sugarCount += sugarPerSecond;
			click.milkCount += milkPerSecond;
			click.creamCount += creamPerSecond;
			click.butterCount += butterPerSecond;
			timer = 0f;
		}
	}
}

