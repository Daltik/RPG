using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


	private List<string> statsListPlayer;
	private List<string> statsListEnemy;

	private string textStats;

	public Text txtPlayerStats;
	public Text txtEnemyStats;


	// Use this for initialization
	void Start () {
	//	printStats();
		
		Player player1 = new Player();
		Enemy enemy1 = new Enemy();
	
		
		statsListPlayer = new List<string>(player1.characterStats("John", 100, true));
		statsListEnemy = enemy1.characterStats("Eddie", 150, true);

		
		txtPlayerStats.text = "Player Stats: \n \n" + player1.printStats(statsListPlayer);
		txtEnemyStats.text = "Enemy Stats: \n \n" + enemy1.printStats(statsListEnemy);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	

	

}
