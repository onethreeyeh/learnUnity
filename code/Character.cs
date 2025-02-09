using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
	public string name;
	public int exp = 0;

	public Character(string name)
	{
		this.name = name;
	}

	//virtual表示子类会重写该方法，该方法是多态的
	public virtual void Output()
	{
		Debug.LogFormat("name:{0} - exp:{1}",this.name,this.exp);
	}
}

public struct Weapon
{
	public string name;
	public int ATK;

	public Weapon(string name,int ATK)
	{
		this.name = name;
		this.ATK = ATK;
	}

	public void Output()
	{
		Debug.LogFormat("WeaponName:{0} - ATK:{1}",this.name,this.ATK);
	}
}