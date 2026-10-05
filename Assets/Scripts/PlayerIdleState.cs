using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(Player player) : base(player) { }

    public override void Enter()
    {
        
    }

    public override void Update()
    {
        base.Update();

        if (player.runPressed)
        {
            player.runPressed = false;
        }
    }

    public override void Exit()
    {
        
    }
}
