using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaJump : BaseState
{
    public NinjaJump(PlayerController controller) : base(controller) { }

    public override void Enter()
    {
        controller.animator.SetTrigger("Jump");
    }

    public override void Update()
    {
        controller.Jump();

        if (!Mathf.Approximately(DPad.GetHorizontalInput(), 0f))
        {
            controller.ChangeState(new NinjaRun(controller));
        }
        else if (DPad.GetButtonAttack())
        {
            controller.ChangeState(new NinjaAttack(controller));
        }
        else if (DPad.GetButtonThrow())
        {
            controller.ChangeState(new NinjaThrow(controller));
        }
        else if(controller.isGrounded)
        {
            controller.ChangeState(new NinjaIdle(controller));
        }
    }

    public override void Exit() { }
}
