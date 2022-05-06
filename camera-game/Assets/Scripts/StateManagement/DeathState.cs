using UnityEngine;
using UnityEngine.Events;
using System;
using System.Collections;
using System.Collections.Generic;
public class DeathState : State
{
    public string deathAnimationVariable = "isDead";
    protected override void Awake()
    {
        base.Awake();
        stateMachine.RegisterState(deathAnimationVariable, this);
    }

    public override void Enter()
    {
        base.Enter();
        animator.SetBool(deathAnimationVariable,true);
    }

    public override void HandleInput()
    {
    }
    public override void HandleShouldChangeState()
    {
    }
    public override void LogicUpdate()
    {
    }
    public override void PhysicsUpdate()
    {
    }
}