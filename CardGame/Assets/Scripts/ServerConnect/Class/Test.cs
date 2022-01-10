using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Test", menuName ="Test")]
public class Test :ScriptableObject
{
    public int id;
    public new string name;
    public int weight;
    public int[] questionList;
    public int[] criterion;

    public Test()
    {
        id=0;
        name="none";
        weight=0;
        questionList=new int[]{1,2,3};
        criterion=new int[]{80,60,40};
    }
}


