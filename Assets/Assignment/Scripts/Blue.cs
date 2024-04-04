using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : Square
{
    public override WhichItem Collect()
    {
        return WhichItem.Dagger;
    }
}
