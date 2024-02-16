using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Days : MonoBehaviour
{
    public DaysEnum testEnum;
    void Start()
    {
        switch (testEnum)
        {
            case DaysEnum.Monday: Debug.Log("Monday"); break;
            case DaysEnum.Tuesday: Debug.Log("Tuesday"); break;
            case DaysEnum.Wednesday: Debug.Log("Wednesday"); break;
            case DaysEnum.Thursday: Debug.Log("Thursday"); break;
            case DaysEnum.Friday: Debug.Log("Friday"); break;
            case DaysEnum.Saturday: Debug.Log("Saturday"); break;
            case DaysEnum.Sunday: Debug.Log("Sunday"); break;
        }
    }


    void Update()
    {
        
    }
}
