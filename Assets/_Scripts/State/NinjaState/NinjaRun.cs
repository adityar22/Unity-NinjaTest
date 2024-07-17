using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaRun : BaseState
{
    public NinjaRun(PlayerController controller) : base(controller) { }

    public override void Enter()
    {
        controller.animator.SetTrigger("Run");
    }

    public override void Update()
    {
        float moveInput = DPad.GetHorizontalInput();
        controller.Move(DPad.Direction);

        if (Mathf.Approximately(moveInput, 0f))
        {
            controller.ChangeState(new NinjaIdle(controller));
        }
        else if (DPad.GetButtonJump())
        {
            controller.ChangeState(new NinjaJump(controller));
        }
        else if (DPad.GetButtonSlide())
        {
            controller.ChangeState(new NinjaSlide(controller));
        }
        else if (DPad.GetButtonAttack())
        {
            controller.ChangeState(new NinjaAttack(controller));
        }
        else if (DPad.GetButtonThrow())
        {
            controller.ChangeState(new NinjaThrow(controller));
        }
    }

    public override void Exit() { }
}
