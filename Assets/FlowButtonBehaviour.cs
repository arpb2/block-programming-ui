using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ARPB2Engine.Model;

public class FlowButtonBehaviour : MonoBehaviour
{

    public int number;



    public ILiteral GetModel()
    {
        return new Number(number);
    }


}
