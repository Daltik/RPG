using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Characters : MonoBehaviour{

	protected string name;
	protected int health;
	protected bool alive;
	private string textStats;

	protected List<string> statsList = new List<string>();

	public void attack(){
		
	}

	public void damage(){

	}

	public void death(){

	}

	public List<string> characterStats(string name, int health, bool alive){
		statsList.Add("Name: " + name);
		statsList.Add("Health: " + health.ToString());
		statsList.Add("Alive: " + alive.ToString());
		
		return statsList;

	}

	public string printStats(List<string> list){
				

		for (int i = 0; i < list.Count; i++){
				textStats =  textStats + list[i] + "\n";
				
		}
	
		return textStats;
	}

}
