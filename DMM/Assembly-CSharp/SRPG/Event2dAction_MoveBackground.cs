// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_MoveBackground
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001294")]
  [EventActionInfo("背景/移動(2D)", "背景を指定した位置に移動させます", 5592405, 4473992)]
  public class Event2dAction_MoveBackground : EventAction
  {
    [Token(Token = "0x40044C4")]
    [FieldOffset(Offset = "0x18")]
    public float MoveTime;
    [Token(Token = "0x40044C5")]
    [FieldOffset(Offset = "0x1C")]
    public Vector3 MoveFrom;
    [Token(Token = "0x40044C6")]
    [FieldOffset(Offset = "0x28")]
    public Vector3 MoveTo;
    [Token(Token = "0x40044C7")]
    [FieldOffset(Offset = "0x34")]
    public bool Async;
    [Token(Token = "0x40044C8")]
    [FieldOffset(Offset = "0x38")]
    private EventBackGround mBackGround;
    [Token(Token = "0x40044C9")]
    [FieldOffset(Offset = "0x3C")]
    private Vector3 FromPosition;
    [Token(Token = "0x40044CA")]
    [FieldOffset(Offset = "0x48")]
    private Vector3 ToPosition;
    [Token(Token = "0x40044CB")]
    [FieldOffset(Offset = "0x54")]
    private readonly float MOVE_TIME;
    [Token(Token = "0x40044CC")]
    [FieldOffset(Offset = "0x58")]
    private float offset;

    [Token(Token = "0x6004EB4")]
    [Address(RVA = "0x123F770", Offset = "0x123E570", VA = "0x1123F770", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004EB5")]
    [Address(RVA = "0x123F6C0", Offset = "0x123E4C0", VA = "0x1123F6C0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EB6")]
    [Address(RVA = "0x123F800", Offset = "0x123E600", VA = "0x1123F800", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EB7")]
    [Address(RVA = "0x123F980", Offset = "0x123E780", VA = "0x1123F980")]
    public Event2dAction_MoveBackground()
    {
    }
  }
}
