// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_MoveObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001295")]
  [EventActionInfo("オブジェクト/パン(2D)", "パン", 5592405, 4473992)]
  public class Event2dAction_MoveObject : EventAction
  {
    [Token(Token = "0x40044CD")]
    [FieldOffset(Offset = "0x18")]
    public Vector3 MoveFrom;
    [Token(Token = "0x40044CE")]
    [FieldOffset(Offset = "0x24")]
    public Vector3 MoveTo;
    [Token(Token = "0x40044CF")]
    [FieldOffset(Offset = "0x30")]
    public float MoveTime;
    [Token(Token = "0x40044D0")]
    [FieldOffset(Offset = "0x34")]
    public bool Async;
    [Token(Token = "0x40044D1")]
    [FieldOffset(Offset = "0x38")]
    private Vector3 FromPosition;
    [Token(Token = "0x40044D2")]
    [FieldOffset(Offset = "0x44")]
    private Vector3 ToPosition;

    [Token(Token = "0x6004EB8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004EB9")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EBA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EBB")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_MoveObject()
    {
    }
  }
}
