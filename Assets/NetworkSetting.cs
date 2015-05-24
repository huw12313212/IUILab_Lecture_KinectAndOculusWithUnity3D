using UnityEngine;
using System.Collections;

public class NetworkSetting : Photon.MonoBehaviour {

	public KinectManager kinect;


	void OnJoinedLobby()
	{
		Debug.Log("JoinRandom");
		PhotonNetwork.JoinRandomRoom();
	}
	void OnPhotonRandomJoinFailed()
	{
		PhotonNetwork.CreateRoom(null);
	}


	void OnCreatedRoom() {
		Debug.Log("created room");
		//CheckKinect ();
	}

	void OnJoinedRoom()
	{
		Debug.Log ("joined room");
		CheckKinect ();
	}

	void CheckKinect()
	{
		if (kinect.IsInitialized()) 
		{	
			Debug.Log("Request Owner");

			GameObject [] objects =	GameObject.FindGameObjectsWithTag("Network");

			foreach(GameObject o in objects)
			{
				o.GetComponent<PhotonView>().RequestOwnership();
				//o.GetComponent<PhotonView>().on
				//o.GetComponent<PhotonView>().
				Debug.Log("Requset:"+o.name);
			}
				
		}
	}

	// Use this for initialization
	void Start () {

		if (!PhotonNetwork.connected)
			PhotonNetwork.ConnectUsingSettings("v1.0");
		//PhotonNetwork.
		//PhotonNetwork.CreateRoom("room1");
		//PhotonNetwork.JoinRoom
		//Invoke ("CheckKinect",1);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
