public abstract class SkillFxEventData : FxEventData
{
    public override void OnEvent(Unit owner, object args = null)
    {
        var skill = (Skill)args;
        OnSkillEvent(owner, skill);
    }

    public override void OnEndEvent(Unit owner, object args = null)
    {

    }

    public abstract void OnSkillEvent(Unit owner, Skill skill);
}
