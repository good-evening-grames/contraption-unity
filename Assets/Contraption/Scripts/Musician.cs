using UnityEngine;
using System.Collections;
using NDream.AirConsole;
using Newtonsoft.Json.Linq;

public class Musician : MonoBehaviour
{
    public int id;

    void Awake ()
    {
        AirConsole.instance.onMessage += OnMessage;
        AirConsole.instance.onDisconnect += OnDisconnect;
    }

	void Start ()
    {
	
	}

	void Update ()
    {
	
	}

    void OnDisconnect(int device_id)
    {
        if (device_id == id)
        {
            Debug.Log("Controller " + device_id + " disconnected.");
            Destroy(gameObject);
        }
    }

    void OnMessage(int device_id, JToken data)
    {
        if (device_id == id)
        {
            Debug.Log("Message " + data + " received by player id " + id);
        }
    }
}
