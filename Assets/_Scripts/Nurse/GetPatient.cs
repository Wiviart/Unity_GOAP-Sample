using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPatient : GAction
{
    public override bool PostPerform()
    {
        target = GWorld.Instance.GetAndRemovePatient();

        if (target == null)
            return false;

        return true;
    }

    public override bool PrePerform()
    {
        return true;
    }
}
