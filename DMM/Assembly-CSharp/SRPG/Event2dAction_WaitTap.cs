// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_WaitTap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012C1")]
  [EventActionInfo("New/待機", "待機します。", 5592405, 4473992)]
  public class Event2dAction_WaitTap : EventAction
  {
    [Token(Token = "0x40045EF")]
    [FieldOffset(Offset = "0x18")]
    public bool tapWaiting;
    [Token(Token = "0x40045F0")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public float WaitSeconds;
    [Token(Token = "0x40045F1")]
    [FieldOffset(Offset = "0x20")]
    private float mTimer;
    [Token(Token = "0x40045F2")]
    [FieldOffset(Offset = "0x24")]
    private bool waitFrame;

    [Token(Token = "0x6004F82")]
    [Address(RVA = "0x12487F0", Offset = "0x12475F0", VA = "0x112487F0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F83")]
    [Address(RVA = "0x1248810", Offset = "0x1247610", VA = "0x11248810", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004F84")]
    [Address(RVA = "0x12487C0", Offset = "0x12475C0", VA = "0x112487C0", Slot = "8")]
    public override bool Forward() => new bool();

    [Token(Token = "0x6004F85")]
    [Address(RVA = "0x1227D90", Offset = "0x1226B90", VA = "0x11227D90")]
    public Event2dAction_WaitTap()
    {
    }
  }
}
