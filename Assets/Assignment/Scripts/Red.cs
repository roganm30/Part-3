using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : Square
{
    public override WhichItem Collect()
    {
        return WhichItem.Shovel;
    }
}
