using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
  void DestroyGameObject()
  {
      Destroy(gameObject);
  }

void DestroyScriptInstance()
{
    Destroy(this);
}
void DestroyGameObjectDelayed()
{
    Destroy(gameObject, 5);
}

void Update()
{
    if(Input.GetButton("Fire1")&& GetComponent<BoxCollider>())
    {
        Destroy(GetComponent<BoxCollider>());
    }    
}

}
