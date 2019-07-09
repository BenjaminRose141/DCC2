using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetParticle : MonoBehaviour
{
   [SerializeField] Vector3 positionStart1;
   [SerializeField] Vector3 positionStart2;
   [SerializeField] GameObject particle1;
   [SerializeField] GameObject particle2;


   void OnEnable()
   {
       Debug.Log("OnEnable called");
       particle1.gameObject.transform.position = positionStart1;
       particle2.gameObject.transform.position = positionStart2;
   }
}
