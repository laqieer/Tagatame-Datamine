// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_MoveStandChara2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001297")]
  [EventActionInfo("立ち絵2/移動(2D)", "立ち絵2を指定した位置に移動させます。", 5592405, 4473992)]
  public class Event2dAction_MoveStandChara2 : EventAction
  {
    [Token(Token = "0x40044DB")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x40044DC")]
    [FieldOffset(Offset = "0x1C")]
    public float MoveTime;
    [Token(Token = "0x40044DD")]
    [FieldOffset(Offset = "0x20")]
    public EventStandCharaController2.PositionTypes MoveTo;
    [Token(Token = "0x40044DE")]
    [FieldOffset(Offset = "0x24")]
    private EventStandCharaController2 mStandChara;
    [Token(Token = "0x40044DF")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 FromPostion;
    [Token(Token = "0x40044E0")]
    [FieldOffset(Offset = "0x34")]
    private Vector3 ToPostion;
    [Token(Token = "0x40044E1")]
    [FieldOffset(Offset = "0x40")]
    private float offset;
    [Token(Token = "0x40044E2")]
    [FieldOffset(Offset = "0x44")]
    private Vector2 FromAnchorMin;
    [Token(Token = "0x40044E3")]
    [FieldOffset(Offset = "0x4C")]
    private Vector2 FromAnchorMax;
    [Token(Token = "0x40044E4")]
    [FieldOffset(Offset = "0x54")]
    private RectTransform mStandCharaTransform;
    [Token(Token = "0x40044E5")]
    [FieldOffset(Offset = "0x58")]
    private Vector2 mToAnchor;

    [Token(Token = "0x6004EC0")]
    [Address(RVA = "0x123FAD0", Offset = "0x123E8D0", VA = "0x1123FAD0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004EC1")]
    [Address(RVA = "0x123F9A0", Offset = "0x123E7A0", VA = "0x1123F9A0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EC2")]
    [Address(RVA = "0x123FB60", Offset = "0x123E960", VA = "0x1123FB60", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EC3")]
    [Address(RVA = "0x1227D90", Offset = "0x1226B90", VA = "0x11227D90")]
    public Event2dAction_MoveStandChara2()
    {
    }
  }
}
