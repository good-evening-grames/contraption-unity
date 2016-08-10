using UnityEngine;
using System.Collections;
using NDream.AirConsole;
using Newtonsoft.Json.Linq;

public class Spawner : MonoBehaviour
{
    public GameObject musicianPrefab;

    void Awake ()
    {
        AirConsole.instance.onConnect += OnConnect;
    }

	void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}

    void OnConnect(int device_id)
    {
        Debug.Log("Controller " + device_id + " connected.");
        GameObject musician = (GameObject)Instantiate(musicianPrefab, transform.position, transform.rotation);
        musician.GetComponent<Musician>().id = device_id;
    }
}
