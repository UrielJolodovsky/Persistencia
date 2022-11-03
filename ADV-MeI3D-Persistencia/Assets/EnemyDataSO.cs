using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "EnemyData",menuName ="SO Enemy Data")]
public class EnemyDataSO : ScriptableObject
{
    public bool defeated;
    public Transform tr;

    public void RotateMe()
    {
        tr.Rotate(45,0,0);
    }

}
