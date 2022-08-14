using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawning : MonoBehaviour
{

   public GameObject CollectibleGameObject;
   public int Count=4;


    // Start is called before the first frame update
    void Start()
    {
     SpawnCubes();
        
    }

    private void SpawnCubes(){

            for(int i=0;i<Count;i++){
                Instantiate(CollectibleGameObject);
            }

    }

    }
