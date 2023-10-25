using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;

    static GWorld()
    {
        world = new WorldStates();
    }

    private GWorld()
    {
    }

    public static GWorld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }

    //*******************************************************//
    //*******************************************************//

    static Queue<GameObject> patients = new Queue<GameObject>();

    public void AddPatient(GameObject p)
    {
        patients.Enqueue(p);
    }

    public GameObject GetAndRemovePatient()
    {
        if (patients.Count == 0)
            return null;
        return patients.Dequeue();
    }
}
