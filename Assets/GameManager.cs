using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private const string PLAYER_ID = "Player ";
    // Player 번호, 정보 담을 딕셔너리
    private static Dictionary<string, PlayerInfo> players = new Dictionary<string, PlayerInfo>();

    public static void RegisterPlayer(string _id, PlayerInfo _player)
    {
        string _playerID = PLAYER_ID + _id;
        players.Add(_playerID, _player);
        _player.transform.name = _playerID;
        Debug.Log("RegisterPlayer: " + _id);
    }

    public static PlayerInfo GetPlayer(string _playerID)
    {
        return players[_playerID];
    }
}
