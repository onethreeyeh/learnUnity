using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish:Character
{
	public Weapon weapon;

	//继承父类构造函数
	public Fish(string name,Weapon weapon):base(name)
	{
		this.weapon = weapon;
	}

	//override表示重写父类的该方法
	public override void Output()
	{
		Debug.LogFormat("name:{0} - exp:{1} - weapon:{2}",this.name,this.exp,this.weapon);
	}
}