using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaDie : BaseState
{
    public NinjaDie(PlayerController controller) : base(controller) {}

    public override void Enter()
    {
        controller.animator.SetTrigger("Die");
    }

    public override void Update()
    {
        
    }

    public override void Exit() {}
}
