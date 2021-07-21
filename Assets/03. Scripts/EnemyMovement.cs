using UnityEngine.AI;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform _player;
    NavMeshAgent _nav;

    PlayerHealth _playerHealth;
    EnemyHealth _enemyHealth;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _nav = GetComponent<NavMeshAgent>();

        _playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        _enemyHealth = GetComponent<EnemyHealth>();
    }

    private void Update()
    {
        if (!_playerHealth.isDead && !_enemyHealth.isDead)
            _nav.SetDestination(_player.position);
        else
            _nav.enabled = false;


    }
}
