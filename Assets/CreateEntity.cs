using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class CreateEntity : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject spawnpoint;
    Transform spawnPos;
    public float maxtime;
    public float timeRemaining;



    [DllImport("random")]
    private static extern int RandomNumberx();

    [DllImport("random")]
    private static extern int RandomNumbery();

    [DllImport("random")]
    private static extern int RandomNumberz();



    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = maxtime;
    }

    private void Update()
    {
        timeRemaining = timeRemaining- Time.deltaTime;

        if (timeRemaining < 0)
        {
            spawnObject.transform.position = new Vector3(spawnpoint.transform.position.x+RandomNumberx(), spawnpoint.transform.position.y+ RandomNumbery(), spawnpoint.transform.position.z+RandomNumberz());
            Instantiate(spawnObject, spawnObject.transform.position, spawnObject.transform.rotation);
            timeRemaining = maxtime;
        }

    }
}
