using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float randomMinSpawnTime = 1;
    [SerializeField] float randomMaxSpawnTime = 5;
    [SerializeField] Attacker[] attackerPrefabs;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(
                UnityEngine.Random.Range(randomMinSpawnTime, randomMaxSpawnTime)
                );
            SpawnAttacker();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnAttacker()
    {
        int index = UnityEngine.Random.Range(0, attackerPrefabs.Length);
        Spawn(attackerPrefabs[index]);
    }

    private void Spawn(Attacker attackerToSpawn)
    {
        Attacker newAttacker = Instantiate(attackerToSpawn, transform.position, transform.rotation);
        newAttacker.transform.parent = transform;
    }
}
