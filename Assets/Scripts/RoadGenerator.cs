using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

#pragma warning disable 0649
public class RoadGenerator : MonoBehaviour
{
    [Header("Prefab of road")]
    public Road[] roadPrefab;

    [Header("Player position")]
    public Transform player;

    [Header("Distance to spawn")] 
    public float distance = 10;

    [SerializeField]
    private List<Road> roads;

    private void GenerateRoad()
    {
        Road newRoad = Instantiate(roadPrefab[Random.Range(0, roadPrefab.Length)]);
        newRoad.transform.position = new Vector2(
            roads[roads.Count - 1].end.position.x + (newRoad.transform.position.x - newRoad.begin.position.x),
            roads[roads.Count - 1].end.position.y + (newRoad.transform.position.y - newRoad.begin.position.y)
            );
        roads.Add(newRoad);
    }

    private void Update()
    {
        if (player.position.x > roads[roads.Count - 1].end.position.x - distance) GenerateRoad();
    }
}
