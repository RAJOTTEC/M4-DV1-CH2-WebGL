using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
	SOActorModel actorModel;
	GameObject playerShip;

	void Start()
	{
		CreatePlayer();
	}

	void CreatePlayer()
	{
		actorModel = Object.Instantiate(Resources.Load("Script/ScriptableObject/Player_Default")) as SOActorModel;
		playerShip = GameObject.Instantiate(actorModel.actor) as GameObject;
		playerShip.GetComponent<Player>().ActorStats(actorModel);

		playerShip.transform.rotation = Quaternion.Euler(-90, 180, 0);
		playerShip.transform.localScale = new Vector3(60, 60, 60);
		playerShip.name = "Player";
		playerShip.transform.SetParent(this.transform);
		playerShip.transform.position = Vector3.zero;
	}
}
