using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;

	void Update ()
	{
		//Topun pozisyonu kameranın pozisyonunun yukarısında ise aşağıdaki olayı yapıyor
		if (player.position.y > transform.position.y)
		{
			//Kameranın topu takip etmesini sağlıyor
			transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
		}
	}

}
