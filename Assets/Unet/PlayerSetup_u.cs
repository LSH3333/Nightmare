using UnityEngine;
using UnityEngine.Networking;
using System.Collections.Generic;

public class PlayerSetup_u : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;

    [SerializeField]
    private Camera scenecam; // main cam
    [SerializeField]
    private GameObject thirdPersonViewCam;

    string myId;

    private void Awake()
    {
        
    }

    private void Start()
    {
        // LocalPlayer가 아니라면 
        if (!isLocalPlayer)
        {
            // RemotePlayer이므로 RemotePlayer에게 필요없는 컴포넌트들을 Disable 한다. 
            DisableComponents();
            // RemotePlayer이므로 layer 변경. 
            AssignRemoteLayer();
            AssignRemoteTag();

        }
        else // is local player 
        {
            scenecam = Camera.main;
            if (scenecam != null)
            {
                scenecam.gameObject.SetActive(false);
            }

            // spawn thirdPersonViewCam
            Instantiate(thirdPersonViewCam, transform.position, Quaternion.identity);
            
        }

        //RegisterID();

    }

    // componentsToDisable 배열에 등록된 컴포넌트들을 Disable 한다. 
    void DisableComponents()
    {
        for(int i = 0; i < componentsToDisable.Length; i++)
        {
            componentsToDisable[i].enabled = false; 
        }
        
    }


    void AssignRemoteLayer()
    {
        gameObject.layer = LayerMask.NameToLayer("RemotePlayer");
    }

    void AssignRemoteTag()
    {
        gameObject.tag = "RemotePlayer";
    }
    

    public string getID()
    {
        return myId;
    }

    public override void OnStartClient()
    {
        base.OnStartClient();

        string _unetID = GetComponent<NetworkIdentity>().netId.ToString();
        PlayerInfo _player = GetComponent<PlayerInfo>();

        GameManager.RegisterPlayer(_unetID, _player);
    }
}
