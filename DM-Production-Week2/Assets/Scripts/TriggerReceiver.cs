using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerReceiver : MonoBehaviour
{
  
    public void Received()
    {
        Debug.Log("Received Event");
    }
    public void Received(GameObject receivedObject)
    {
        Debug.Log("Received " + receivedObject.name);
    }


}
