using System.Collections;
using UnityEngine;

public class SpawnCircle : MonoBehaviour
{
    [SerializeField] private GameObject Circle;
    [SerializeField] private float Frequency;
    [SerializeField] private Transform[] SpawnPosition = new Transform[10];

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Frequency);
        Instantiate(Circle, SpawnPosition[Random.Range(0, SpawnPosition.Length)]);
        yield return Spawn();
    }
}
