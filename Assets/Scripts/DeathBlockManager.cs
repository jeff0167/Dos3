using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBlockManager : MonoBehaviour
{
    public GameObject DeathBlock;
    void Start()
    {
        InvokeRepeating("SpawnBlocks",0,0.5f);
    }

    void SpawnBlocks()
    {
        Instantiate(DeathBlock, RandomPos(), Quaternion.identity);
    }

    Vector2 RandomPos()
    {
        return new Vector2(Random.Range(-10,10),-25);
    }
}
