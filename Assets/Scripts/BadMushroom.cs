using UnityEngine;
using System.Collections;

public class BadMushroom : Pickup {
	public float speed;

	//override = je maakt een extensie van die functie
	public override void PlayerHit(PlayerMovement _GO)
	{
		base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup)
		//voeg hier code toe zo dat de speler zijn score omhoog gaat
		_GO.m_score -= 100;
		Destroy (this.gameObject);

	}
	void Update () {
		transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
	}
}