using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {


	void Start () {
		Debug.Log("start");
		Connect ();
	}

	void Connect(){
		Debug.Log("Connect");
		PhotonNetwork.ConnectUsingSettings("alpha");
	}
	void OnGUI(){
		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString());
	}
	void OnJoinedLobby(){
		Debug.Log("OnJoinedLobby");
		PhotonNetwork.JoinOrCreateRoom ("mmo",null,null);
	}
	void OnPhotonJoinRoomFailed(){
		Debug.Log("OnPhotonJoinRoomFailed");
	}
	void OnJoinedRoom(){
		Debug.Log("OnJoinedRoom");
		spawnMe ();
	}
	
	void spawnMe(){

		
		PhotonNetwork.Instantiate ("OVRCameraRig",Vector3.zero,Quaternion.identity,0/*importent spaceship id*/);

		
	}
}