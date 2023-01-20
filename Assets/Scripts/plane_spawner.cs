using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_spawner : MonoBehaviour
{
    public GameObject[] jet1;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(SpanJets());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void jets(){
        int rand= Random.Range(0,jet1.Length);
        float randXPos=Random.Range(-1.70f,1.70f);
  Instantiate(jet1[rand], new Vector3(randXPos , transform.position.y,transform.position.z), Quaternion.Euler(0,0,0));
    }
    IEnumerator SpanJets(){
        while(true){
        yield return new WaitForSeconds(4);
        jets(); }
    }
}
