using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeLists : MonoBehaviour
{
    public GameObject[] SpawnList = new GameObject[3];
    public List<GameObject> objectsCreated = new List<GameObject>();
    private int SpawnCount { get; set; }

    private bool _initColorChange;

    void Start()
    {
        AssignPrefabs();
    }


    void Update()
    {
        ExecuteSpawning();
    }


    private void AssignPrefabs()
    {
        SpawnList[0] = Resources.Load<GameObject>("Prefabs/ListsPrefabs/Capsule");
        SpawnList[1] = Resources.Load<GameObject>("Prefabs/ListsPrefabs/Cube");
        SpawnList[2] = Resources.Load<GameObject>("Prefabs/ListsPrefabs/Sphere");

        if (SpawnList[0] == null || SpawnList[1] == null || SpawnList[2] == null)
        {
            Debug.Log("Prefab not found");
        }
    }

    private void ExecuteSpawning()
    {
        SpawnRandomObject();
        ColorDeleteObjects();
    }

    private void SpawnRandomObject()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(SpawnCount == 10)
            {
                _initColorChange = true;
                return;
            }

            GameObject objectToSpawn = SpawnList[Random.Range(0, SpawnList.Length)];
            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-10f, 10f);
            Vector3 position = new Vector3(x, y, 0);

            GameObject instances = (GameObject)Instantiate(objectToSpawn, position, Quaternion.identity);

            objectsCreated.Add(instances);
            SpawnCount++;
        }
    }

    private void ColorDeleteObjects()
    {
        if (_initColorChange == true)
        {
            _initColorChange = false;
            foreach (GameObject obj in objectsCreated)
            {
                if (obj != null)
                {
                    obj.GetComponent<Renderer>().material.color = Color.green;
                    Destroy(obj, 1f);
                }
            }

            objectsCreated.Clear();
        }
    }
}
