using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaIdle : BaseState
{
    public NinjaIdle(PlayerController controller) : base(controller) {}

    public override void Enter()
    {
        controller.animator.SetTrigger("Idle");
    }

    public override void Update()
    {
        controller.Move(0f);
              
        if (!Mathf.Approximately(DPad.GetHorizontalInput(), 0f))
        {
            controller.ChangeState(new NinjaRun(controller));
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

    public override void Exit() {}
}
