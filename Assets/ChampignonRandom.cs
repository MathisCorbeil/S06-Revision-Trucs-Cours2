using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampignonRandom : MonoBehaviour
 
{
[SerializeField] Vector3 _positionCreation;

    // Start is called before the first frame update
    void Start()
    {

       float PositionChampi = Random.Range(0f, 1f);
        
       if(PositionChampi > 0.5f){
        transform.position += _positionCreation;
       }



    }

   
}
