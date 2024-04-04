using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : Square
{
    public override WhichItem Collect()
    {
        return WhichItem.Bow;
    }
}
