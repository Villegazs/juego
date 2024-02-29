using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class Llave : PickableItem
{
    protected override void Pick(GameObject picker)
    {
        PickableItemEvent.Trigger(this);
    }
}
