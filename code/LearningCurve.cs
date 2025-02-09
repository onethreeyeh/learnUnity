using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
	public int numberOfCoins = 23;
    // Start is called before the first frame update
    void Start()
    {

    	Character hero = new Character("hero");
    	hero.Output();

    	Weapon sword = new Weapon("sword",23);
    	sword.Output();

    	Fish fishh = new Fish("fishh",sword);
    	fishh.Output();

    	List<string> members = new List<string>(){"yys","2316","LL"};
    	Debug.LogFormat("Party Members:{0}",members.Count);
    	members.Add("yyds");
    	Debug.LogFormat("Party Members:{0}",members.Count);

    	for(int i = 0;i < members.Count;i++)
    	{
    		Debug.LogFormat("{0}-{1}",i,members[i]);
    	}
    	//foreach循环
    	foreach(string mem in members)
    	{
    		Debug.LogFormat("{0} is here!",mem);
    	}
    	//定义字典
    	Dictionary<string,int>nameAndAge = new Dictionary<string,int>()
    	{{"yys",23},{"2316",16},{"LL",27},{"yyds",25}};

    	foreach(KeyValuePair<string,int>kvp in nameAndAge)
    	{
    		Debug.LogFormat("name:{0},age:{1}",kvp.Key,kvp.Value);
    	}

    	Dictionary<string,int>propsAndPrices = new Dictionary<string,int>()
    	{{"sword",50},{"gun",80},{"medicine",5},{"bullet",3}};

    	foreach(KeyValuePair<string,int>kvp in propsAndPrices)
    	{
    		if(kvp.Value <= numberOfCoins)
    		{
    			Debug.LogFormat("You can buy {0}",kvp.Key);
    		}
    		else
    		{
    			Debug.LogFormat("Not enough coins to buy {0}",kvp.Key);
    		}
    	}
    }

    void Yzdsl(int xiaoxiaocanshu)
    {
    	Debug.Log($"传进来的参数是{xiaoxiaocanshu}");
    	return;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
