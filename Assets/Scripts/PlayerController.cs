using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {
//this creates an editable property in our inspector
  public float speed;
//creates a variable to hold the reference
  public Text countText;
  public Text winText;
  private Rigidbody rb;
  private int count;
  void Start()
{
  rb = GetComponent<Rigidbody>();
  count = 0;
  SetCountText ();
  winText.text = "";
}

  void FixedUpdate()
{
  //This is where the physics code will go.
  float moveHorizontal = Input.GetAxis ("Horizontal");
  float moveVertical = Input.GetAxis ("Vertical");
// x , y , z values determine force we will add to ball. x is moveHorizontal, z is moveVertical
  Vector3 movement = new Vector3 ( moveHorizontal, 0.0f, moveVertical);

  rb.AddForce (movement * speed);
}
  void OnTriggerEnter (Collider other)
  {
    if(other.gameObject.CompareTag("Pick Up"))
    {
      other.gameObject.SetActive(false);
      count = count + 1;
      SetCountText ();
    }
  }
  void SetCountText ()
  {
    countText.text = "Count: " + count.ToString ();
      if(count >= 13)
      {
        winText.text = "You Win!";
      }
  }
}
