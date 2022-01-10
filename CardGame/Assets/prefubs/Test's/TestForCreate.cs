using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Main Test", menuName ="Main Test")]
public class TestForCreate :ScriptableObject
{
    public string testPickString;
    public Test test;
    public TestForCreate(Test pickedTest, string httpConTest)
    {
        testPickString=httpConTest;
        test=pickedTest;

    }
}
