using UnityEngine;
using System.Collections;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp= 53; //魔法力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	public void Magic(int power){
		this.mp -= power;
		if (mp > 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

}

public class Test : MonoBehaviour {

	void Start () {
		//int型を配列arrayで初期化する
		int[] array=new int[5];
		//配列に数字を格納する
		array [0] = 10;
		array [1] = 20;
		array [2] = 30;
		array [3] = 40;
		array [4] = 50;

		//コンソールでの表示を順番に繰り返す
		for (int i = 0; i < 5; i++) {
			Debug.Log (array[i]);
		}
			
		//コンソールでの表示を逆順に繰り返す
		for (int i = 4; i > -1; i--) {
			Debug.Log (array[i]);
		}

		//Bossクラスを使用する
		Boss lastboss= new Boss();

		//攻撃、防御を行う
		lastboss.Attack();
		lastboss.Defence (3);

		//魔法を10回使用する
		for (int i = 0; i < 12; i++) {
			Debug.Log ((i+1) + "回目!");
			lastboss.Magic (5);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}