// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_MoveStandChara4
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001299")]
  [EventActionInfo("New/立ち絵2/移動3(2D)", "立ち絵2を指定した位置に移動させます。", 5592405, 4473992)]
  public class Event2dAction_MoveStandChara4 : EventAction
  {
    [Token(Token = "0x40044F2")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x40044F3")]
    [FieldOffset(Offset = "0x1C")]
    public float MoveTime;
    [Token(Token = "0x40044F4")]
    [FieldOffset(Offset = "0x20")]
    public bool async;
    [Token(Token = "0x40044F5")]
    [FieldOffset(Offset = "0x24")]
    public EventStandCharaController2.PositionTypes MoveTo;
    [Token(Token = "0x40044F6")]
    [FieldOffset(Offset = "0x28")]
    public string Emotion;
    [Token(Token = "0x40044F7")]
    [FieldOffset(Offset = "0x2C")]
    private EventStandCharaController2 mStandChara;
    [Token(Token = "0x40044F8")]
    [FieldOffset(Offset = "0x30")]
    private Vector3 FromPostion;
    [Token(Token = "0x40044F9")]
    [FieldOffset(Offset = "0x3C")]
    private Vector3 ToPostion;
    [Token(Token = "0x40044FA")]
    [FieldOffset(Offset = "0x48")]
    private float offset;
    [Token(Token = "0x40044FB")]
    [FieldOffset(Offset = "0x4C")]
    private Vector2 FromAnchorMin;
    [Token(Token = "0x40044FC")]
    [FieldOffset(Offset = "0x54")]
    private Vector2 FromAnchorMax;
    [Token(Token = "0x40044FD")]
    [FieldOffset(Offset = "0x5C")]
    private RectTransform mStandCharaTransform;
    [Token(Token = "0x40044FE")]
    [FieldOffset(Offset = "0x60")]
    private Vector2 mToAnchor;

    [Token(Token = "0x6004EC8")]
    [Address(RVA = "0x1240180", Offset = "0x123EF80", VA = "0x11240180", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004EC9")]
    [Address(RVA = "0x123FFD0", Offset = "0x123EDD0", VA = "0x1123FFD0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004ECA")]
    [Address(RVA = "0x1240210", Offset = "0x123F010", VA = "0x11240210", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004ECB")]
    [Address(RVA = "0x1227D90", Offset = "0x1226B90", VA = "0x11227D90")]
    public Event2dAction_MoveStandChara4()
    {
    }
  }
}
