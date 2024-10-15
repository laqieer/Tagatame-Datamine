// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_MoveStandchara
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001296")]
  [EventActionInfo("立ち絵/移動(2D)", "立ち絵を指定した位置に移動させます。", 5592405, 4473992)]
  public class Event2dAction_MoveStandchara : EventAction
  {
    [Token(Token = "0x40044D3")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x40044D4")]
    [FieldOffset(Offset = "0x1C")]
    public float MoveTime;
    [Token(Token = "0x40044D5")]
    [FieldOffset(Offset = "0x20")]
    public EventStandChara.PositionTypes MoveTo;
    [Token(Token = "0x40044D6")]
    [FieldOffset(Offset = "0x24")]
    private EventStandChara mStandChara;
    [Token(Token = "0x40044D7")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 FromPosition;
    [Token(Token = "0x40044D8")]
    [FieldOffset(Offset = "0x34")]
    private Vector3 ToPosition;
    [Token(Token = "0x40044D9")]
    private const float MOVE_TIME = 0.5f;
    [Token(Token = "0x40044DA")]
    [FieldOffset(Offset = "0x40")]
    private float offset;

    [Token(Token = "0x6004EBC")]
    [Address(RVA = "0x12405F0", Offset = "0x123F3F0", VA = "0x112405F0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004EBD")]
    [Address(RVA = "0x1240370", Offset = "0x123F170", VA = "0x11240370", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EBE")]
    [Address(RVA = "0x1240680", Offset = "0x123F480", VA = "0x11240680", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EBF")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_MoveStandchara()
    {
    }
  }
}
