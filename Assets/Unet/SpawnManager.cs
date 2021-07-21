using UnityEngine;
using UnityEngine.Networking;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject ZomBear;

    [SerializeField]
    private GameObject Zombunny;

    private void Start()
    {
        GameObject spawnedBear = Instantiate(ZomBear);
        NetworkServer.Spawn(spawnedBear);
    }
}
