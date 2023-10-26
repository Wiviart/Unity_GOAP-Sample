using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject patientPrefab;
    public int numPatients;
    public List<GameObject> patientPool;

    void Start()
    {
        SpawnPatient();

        InvokeRepeating(nameof(StartPatient), 1, Random.Range(2, 10));
    }

    void SpawnPatient()
    {
        for (int i = 0; i < numPatients; i++)
        {
            GameObject patient = Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
            patient.SetActive(false);
            patient.name = "Patient " + i;
            patientPool.Add(patient);

            // Debug.Log("SpawnPatient " + i);
        }
    }

    void StartPatient()
    {
        foreach (var p in patientPool)
        {
            if (p.activeInHierarchy)
            {
                // Debug.Log("Patient " + p.name + " is active");
                continue;
            }

            // Debug.Log("Start Patient " + p.name);

            p.SetActive(true);
            p.transform.position = this.transform.position;
            return;
        }
    }
}
