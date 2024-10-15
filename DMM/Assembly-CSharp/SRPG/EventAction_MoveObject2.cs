// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_MoveObject2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200121E")]
  [EventActionInfo("New/オブジェクト/移動", "シーン上のオブジェクトを移動させます。", 4478293, 4491400)]
  public class EventAction_MoveObject2 : EventAction
  {
    [Token(Token = "0x400426B")]
    [FieldOffset(Offset = "0x18")]
    [StringIsObjectList]
    public string TargetID;
    [Token(Token = "0x400426C")]
    [FieldOffset(Offset = "0x1C")]
    public ObjectAnimator.CurveType Curve;
    [Token(Token = "0x400426D")]
    [FieldOffset(Offset = "0x20")]
    public Vector3 Position;
    [Token(Token = "0x400426E")]
    [FieldOffset(Offset = "0x2C")]
    public Vector3 Rotation;
    [Token(Token = "0x400426F")]
    [FieldOffset(Offset = "0x38")]
    public float Time;
    [Token(Token = "0x4004270")]
    [FieldOffset(Offset = "0x3C")]
    public bool Async;
    [Token(Token = "0x4004271")]
    [FieldOffset(Offset = "0x40")]
    private ObjectAnimator mAnimator;

    [Token(Token = "0x6004CD9")]
    [Address(RVA = "0x121F7D0", Offset = "0x121E5D0", VA = "0x1121F7D0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CDA")]
    [Address(RVA = "0x121F910", Offset = "0x121E710", VA = "0x1121F910", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CDB")]
    [Address(RVA = "0x121F990", Offset = "0x121E790", VA = "0x1121F990")]
    public EventAction_MoveObject2()
    {
    }
  }
}
