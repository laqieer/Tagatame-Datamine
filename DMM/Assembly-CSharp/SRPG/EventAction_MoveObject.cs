// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_MoveObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200121D")]
  [EventActionInfo("オブジェクト/移動", "シーン上のオブジェクトを移動させます。", 4478293, 4491400)]
  public class EventAction_MoveObject : EventAction
  {
    [Token(Token = "0x4004264")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string TargetID;
    [Token(Token = "0x4004265")]
    [FieldOffset(Offset = "0x1C")]
    public ObjectAnimator.CurveType Curve;
    [Token(Token = "0x4004266")]
    [FieldOffset(Offset = "0x20")]
    public Vector3 Position;
    [Token(Token = "0x4004267")]
    [FieldOffset(Offset = "0x2C")]
    public Vector3 Rotation;
    [Token(Token = "0x4004268")]
    [FieldOffset(Offset = "0x38")]
    public float Time;
    [Token(Token = "0x4004269")]
    [FieldOffset(Offset = "0x3C")]
    public bool Async;
    [Token(Token = "0x400426A")]
    [FieldOffset(Offset = "0x40")]
    private ObjectAnimator mAnimator;

    [Token(Token = "0x6004CD5")]
    [Address(RVA = "0x121FAD0", Offset = "0x121E8D0", VA = "0x1121FAD0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CD6")]
    [Address(RVA = "0x121FC10", Offset = "0x121EA10", VA = "0x1121FC10", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CD7")]
    [Address(RVA = "0x121F9B0", Offset = "0x121E7B0", VA = "0x1121F9B0", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004CD8")]
    [Address(RVA = "0x121F990", Offset = "0x121E790", VA = "0x1121F990")]
    public EventAction_MoveObject()
    {
    }
  }
}
