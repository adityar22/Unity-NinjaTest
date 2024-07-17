using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaSlide : BaseState
{
    public NinjaSlide(PlayerController controller) : base(controller) { }

    public override void Enter()
    {
        controller.animator.SetTrigger("Slide");
    }

    public override void Update()
    {
        controller.Move(DPad.Direction);
        
        if (!Mathf.Approximately(DPad.GetHorizontalInput(), 0f))
        {
            controller.ChangeState(new NinjaRun(controller));
        }
        else if (DPad.GetButtonJump())
        {
            controller.ChangeState(new NinjaJump(controller));
        }
        else
        {
            controller.ChangeState(new NinjaIdle(controller));
        }
    }

    public override void Exit() { }
}
