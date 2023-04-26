using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class DroneObjectPool : MonoBehaviour
{
    public int maxPoolSize = 10;
    public int stactcapacity = 10;

    public IObjectPool<Drone> Pool
    {
        get
        {
            if(_pool ==null)
            {
                _pool = new ObjectPool<Drone>(CreatedPooledItem, OnTakeFromPool, OnReturnToPool, OnDestroyPoolObject, true, stactcapacity, maxPoolSize);
               
            }
            return _pool;
        }

    }
    private IObjectPool<Drone> _pool;

    private Drone CreatedPooledItem()
    {
        var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Drone drone = go.AddComponent<Drone>();
        go.name = "Drone";
        drone.Pool = Pool;
        return drone;
    }

    private void OnDestroyPoolObject(Drone obj)
    {
        Destroy(obj.gameObject);
    }

    private void OnReturnToPool(Drone obj)
    {
        obj.gameObject.SetActive(false);
    }

    private void OnTakeFromPool(Drone obj)
    {
        obj.gameObject.SetActive(true);
    }

    public void Spawn()
    {
        var amount = UnityEngine.Random.Range(1, 10);
        for(int i =0;i<amount;i++)
        {
            var drone = Pool.Get();
            drone.transform.position = UnityEngine.Random.insideUnitSphere * 10;
        }
    }
  
}
