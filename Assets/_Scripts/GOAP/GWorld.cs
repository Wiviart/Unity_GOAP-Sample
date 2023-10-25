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

        StartCubicles();
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

    //*******************************************************//
    //*******************************************************//

    static Queue<GameObject> cubicles = new Queue<GameObject>();

    static void StartCubicles()
    {
        cubicles.Clear();

        GameObject[] cubics = GameObject.FindGameObjectsWithTag("Cubicle");

        foreach (var c in cubics)
        {
            cubicles.Enqueue(c);
        }

        if (cubics.Length > 0)
        {
            world.ModifyState("FreeCubicle", cubics.Length);
        }
    }

    public void AddCubicle(GameObject p)
    {
        cubicles.Enqueue(p);
    }

    public GameObject GetAndRemoveCubicle()
    {
        if (cubicles.Count == 0)
            return null;
        return cubicles.Dequeue();
    }
}
