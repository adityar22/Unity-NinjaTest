using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaHurt : BaseState
{
    public NinjaHurt(PlayerController controller) : base(controller) { }

    public override void Enter()
    {
        controller.animator.SetTrigger("Hurt");
    }

    public override void Update()
    {
        if (!Mathf.Approximately(DPad.GetHorizontalInput(), 0f))
        {
            controller.ChangeState(new NinjaRun(controller));
        }
        else
        {
            controller.ChangeState(new NinjaIdle(controller));
        }
    }

    public override void Exit() { }
}
