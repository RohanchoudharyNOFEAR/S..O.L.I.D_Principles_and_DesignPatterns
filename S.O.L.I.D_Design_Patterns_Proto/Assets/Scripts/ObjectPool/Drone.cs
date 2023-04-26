using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Drone : MonoBehaviour
{
    public IObjectPool<Drone> Pool { get; set; }

    public float _currenHealth;
    [SerializeField] private float _maxHealth = 100f;

    [SerializeField] float TimeToselfDestruct = 3f;

    private void Start()
    {
        _currenHealth = _maxHealth;
    }

    private void OnEnable()
    {
        AttackPlayer();
        StartCoroutine(SelfDestruct());
    }
    private void OnDisable()
    {
        ResetDrone();
    }


    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(TimeToselfDestruct);
        TakeDamage(_maxHealth);
    }

    private void ReturnToPool()
    {
        Pool.Release(this);
    }

    private void ResetDrone()
    {
        _currenHealth = _maxHealth;
    }
    public void AttackPlayer()
    {
        Debug.Log("Attacks Player");
    }
    public void TakeDamage(float amount)
    {
        _currenHealth -= amount;
        if(_currenHealth<=0)
        {
            ReturnToPool();
        }
    }


}
