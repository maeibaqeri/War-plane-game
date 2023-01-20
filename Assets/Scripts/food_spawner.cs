using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_spawner : MonoBehaviour
{
     public GameObject foodPrefabs;
    // Start is called before the first frame update
  void Start()
    {
       
        StartCoroutine(FoodSpawner());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FoodSpawn(){
        float rand = Random.Range(-1.70f,1.70f);
        Instantiate(foodPrefabs, new Vector3(rand, transform.position.y , transform.position.z),Quaternion.identity);
    }


    IEnumerator FoodSpawner(){
        while (true)
        {
            int time= Random.Range(8,20);
            yield return new WaitForSeconds(time);
            FoodSpawn();
        }
    }
}
