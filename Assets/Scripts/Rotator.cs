using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour{
  // Update is called once per frame
    void Update()
    {
      //the multiply makes it smooth and framerate independent
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
    }
}
