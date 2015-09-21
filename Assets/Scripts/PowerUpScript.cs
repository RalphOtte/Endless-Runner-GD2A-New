using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	HUDscript hud;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "player") {
			hud = GameObject.Find ("Main Camera").GetComponent<HUDscript>();
			hud.IncreaseScore(10);
			Destroy(this.gameObject);
		}

	}

}
