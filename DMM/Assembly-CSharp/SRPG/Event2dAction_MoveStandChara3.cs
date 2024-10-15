// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_MoveStandChara3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001298")]
  [EventActionInfo("New/立ち絵2/移動2(2D)", "立ち絵2を指定した位置に移動させます。", 5592405, 4473992)]
  public class Event2dAction_MoveStandChara3 : EventAction
  {
    [Token(Token = "0x40044E6")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x40044E7")]
    [FieldOffset(Offset = "0x1C")]
    public float MoveTime;
    [Token(Token = "0x40044E8")]
    [FieldOffset(Offset = "0x20")]
    public bool async;
    [Token(Token = "0x40044E9")]
    [FieldOffset(Offset = "0x24")]
    public EventStandCharaController2.PositionTypes MoveTo;
    [Token(Token = "0x40044EA")]
    [FieldOffset(Offset = "0x28")]
    private EventStandCharaController2 mStandChara;
    [Token(Token = "0x40044EB")]
    [FieldOffset(Offset = "0x2C")]
    private Vector3 FromPostion;
    [Token(Token = "0x40044EC")]
    [FieldOffset(Offset = "0x38")]
    private Vector3 ToPostion;
    [Token(Token = "0x40044ED")]
    [FieldOffset(Offset = "0x44")]
    private float offset;
    [Token(Token = "0x40044EE")]
    [FieldOffset(Offset = "0x48")]
    private Vector2 FromAnchorMin;
    [Token(Token = "0x40044EF")]
    [FieldOffset(Offset = "0x50")]
    private Vector2 FromAnchorMax;
    [Token(Token = "0x40044F0")]
    [FieldOffset(Offset = "0x58")]
    private RectTransform mStandCharaTransform;
    [Token(Token = "0x40044F1")]
    [FieldOffset(Offset = "0x5C")]
    private Vector2 mToAnchor;

    [Token(Token = "0x6004EC4")]
    [Address(RVA = "0x123FDE0", Offset = "0x123EBE0", VA = "0x1123FDE0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004EC5")]
    [Address(RVA = "0x123FCA0", Offset = "0x123EAA0", VA = "0x1123FCA0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EC6")]
    [Address(RVA = "0x123FE70", Offset = "0x123EC70", VA = "0x1123FE70", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EC7")]
    [Address(RVA = "0x1227D90", Offset = "0x1226B90", VA = "0x11227D90")]
    public Event2dAction_MoveStandChara3()
    {
    }
  }
}
