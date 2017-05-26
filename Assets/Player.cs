using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	//Zıplama kuvveti
	public float jumpForce = 10f;

	//Yerçekimi ekleme
	public Rigidbody2D rb;
	//Resim
	public SpriteRenderer sr;
	//Şimdiki renk
	public string currentColor;

	//Renklerimiz
	public Color colorCyan;
	public Color colorYellow;
	public Color colorMagenta;
	public Color colorPink;

	void Start ()
	{
		//Rastgele renk e başla
		SetRandomColor();
	}
	
	
	void Update () {
		//Basıldığında zıplama kuvveti uyguluyor
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			rb.velocity = Vector2.up * jumpForce;
		}
	}

	//Top bir sonraki yere girince rastgele renk alıyor
	void OnTriggerEnter2D (Collider2D col)
	{
		//Eğer renk değiştirme yerine çarparsa aşağıdaki
		if (col.tag == "ColorChanger")
		{
			SetRandomColor();
			Destroy(col.gameObject);
			return;
		}

		// Çemberde çarptığımız renk kendi rengimiz değilse oyun bitiyor yanıyoruz
		if (col.tag != currentColor)
		{
			Debug.Log("GAME OVER!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	void SetRandomColor ()
	{
		//Random ile rastgele sayı veriyor. Gelen sayıya göre renk seçiyor
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentColor = "Cyan";
				sr.color = colorCyan;
				break;
			case 1:
				currentColor = "Yellow";
				sr.color = colorYellow;
				break;
			case 2:
				currentColor = "Magenta";
				sr.color = colorMagenta;
				break;
			case 3:
				currentColor = "Pink";
				sr.color = colorPink;
				break;
		}
	}
}
