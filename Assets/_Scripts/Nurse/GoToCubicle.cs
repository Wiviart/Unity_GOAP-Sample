using UnityEngine;

public class GoToCubicle : GAction
{
    public override bool PrePerform()
    {
        target = inventory.FindItemWithTag("Cubicle");

        if (target == null)
            return false;

        GWorld.Instance.GetWorld().ModifyState("TreatingPatient", 1);
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("TreatingPatient", -1);
        GWorld.Instance.GetWorld().ModifyState("FreeCubicle", 1);
        GWorld.Instance.AddCubicle(target);

        inventory.RemoveItem(target);

        return true;
    }
}