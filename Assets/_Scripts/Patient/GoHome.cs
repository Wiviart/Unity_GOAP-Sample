public class GoHome : GAction
{
    public override bool PrePerform()
    {

        return true;
    }

    public override bool PostPerform()
    {

        gameObject.SetActive(false);
        return true;
    }
}
