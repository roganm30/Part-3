using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public float delay = 0.3f;
    public float delay2 = 0.3f;


    protected override void Attack()
    {
        base.Attack();
        Invoke("SpawnDagger", delay);
        Invoke("SpawnDagger2", delay2);
        Invoke("SpeedIncrease", 0f);
        Invoke("SpeedDecrease", 0.2f);

    }

    void SpawnDagger()
    {
        Instantiate(daggerPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    void SpawnDagger2()
    {
        Instantiate(daggerPrefab, spawnPoint2.position, spawnPoint2.rotation);
    }

    void SpeedIncrease()
    {
       speed = 15f;
    }

    void SpeedDecrease()
    {
        speed = 3f;
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
