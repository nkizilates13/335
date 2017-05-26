using UnityEngine;

public class Rotator : MonoBehaviour {
	// Dönme hızı
	public float speed = 100f;
	
	
	// Çemberi döndürür
	void Update () {
		transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}
}
