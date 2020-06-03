using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool isSpawning = true;
    [SerializeField] float randomMinSpawnTime = 1;
    [SerializeField] float randomMaxSpawnTime = 5;
    [SerializeField] Attacker[] attackerPrefabs;

    public bool IsSpawning()
    {
        return this.isSpawning;
    }

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (isSpawning)
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

    public void StopSpawning()
    {
        this.isSpawning = false;
    }
}
