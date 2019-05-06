    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class Lobby_Network : MonoBehaviourPunCallbacks 
{
    public static Lobby_Network instance = null;
    public InputField roomname;
    public Text connectionText;
    public GameObject roomprefab;
    public List<GameObject> roomprefabs = new List<GameObject>();
    List<RoomInfo> createdRooms = new List<RoomInfo>();
    public GameObject refreshButton;

    TypedLobby sqlLobby = new TypedLobby("myLobby", LobbyType.SqlLobby);

    void Start()
    {
        print("Connecting to Master Server.....");
        PhotonNetwork.AutomaticallySyncScene = true;
        refreshButton.SetActive(false);
        PhotonNetwork.ConnectUsingSettings();
        
    }
   /* public void connecttoserverbutton()
    {
        print("Connecting to Master Server.....");
        PhotonNetwork.AutomaticallySyncScene = true;
        refreshButton.SetActive(false);
        PhotonNetwork.ConnectUsingSettings();
    }*/

    void Update()
    {
        connectionText.text = PhotonNetwork.NetworkClientState.ToString();

    }

    public void OnCreateRoomClicked()
    {
        print("Create room button has been clicked");
        RoomOptions roomOptions = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = 2 };
        PhotonNetwork.CreateRoom(roomname.text, roomOptions, TypedLobby.Default);
        print("Room has been created");

    }

    public void OnJoinRandomRoomClicked()
    {
        print("You have joined a random room.");
        PhotonNetwork.JoinRandomRoom();
    }
    public void OnRefreshRoomListClicked()
    {
       
        if (createdRooms.Count == 0)
        {
            print("no rooms have been created");
        }
        else
        {
           
            for (int i = 0; i < createdRooms.Count; i++)
            {

                RoomOptions roomOptions = new RoomOptions() { IsVisible = false, IsOpen = true, MaxPlayers = 2 };
                print("Destroy commencing");
                //Destroy(roomprefabs[i]);
                roomprefabs.Clear();
                
                print("Room name " + createdRooms[i].Name + "   "+ i + "Size of list "+createdRooms.Count);
                // print("The test count is : " + roomprefabs.Capacity);

                GameObject a = Instantiate(roomprefab);
                a.transform.SetParent(roomprefab.transform.parent);

                a.GetComponent<RectTransform>().localScale = roomprefab.GetComponent<RectTransform>().localScale;

                a.GetComponent<RectTransform>().localPosition = new Vector3(roomprefab.GetComponent<RectTransform>().localPosition.x, roomprefab.GetComponent<RectTransform>().localPosition.y - (i * 80), roomprefab.GetComponent<RectTransform>().localPosition.z);

                a.transform.Find("Room_Name").GetComponent<Text>().text = createdRooms[i].Name;



                a.transform.Find("Join_Button").GetComponent<Button>().onClick.AddListener(() => { PhotonNetwork.JoinOrCreateRoom(createdRooms[i-1].Name, roomOptions, TypedLobby.Default, null); });
               
                    print("Testing : " + i + "Room name that you clicked"  );

                a.SetActive(true);
                roomprefabs.Add(a);
                
                
            }
            
        }
       

    }

    public void refreshtest()
    {
      
        PhotonNetwork.LeaveLobby();
        
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        roomprefabs.Clear();
        base.OnRoomListUpdate(roomList);
     
       
        createdRooms.Clear();
        createdRooms = roomList;
        OnRefreshRoomListClicked();
        print("Room List has been updated");
    }


    public override void OnConnectedToMaster()
    {
        print("Player has established connection to the master server");

        PhotonNetwork.JoinLobby();

    }
    public override void OnJoinedLobby()
    {
        refreshButton.SetActive(true);
        print("You have Joined the game lobby.");
        OnRefreshRoomListClicked();


    }
    
    public override void OnJoinedRoom()
    {
        print("You have Joined the room.");
        
    }



    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        print("Failed to join room");
        
    }

    public override void OnCreatedRoom()
    {
        print("You have created a room.");
        PhotonNetwork.LoadLevel("Co-op_Level");
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        print("You have failed to create a room");
    }
    public override void OnLeftLobby()
    {
        refreshButton.SetActive(false);
        PhotonNetwork.JoinLobby();
       
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        base.OnJoinRandomFailed(returnCode, message);
        print("Failed to join random room");
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        //base.OnDisconnected(cause);
        PhotonNetwork.ConnectUsingSettings();

    }
}
