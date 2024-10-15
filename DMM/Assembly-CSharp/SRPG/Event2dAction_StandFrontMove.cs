// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_StandFrontMove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012B9")]
  [EventActionInfo("New/立ち絵2/最前面移動(2D)", "指定した立ち絵を最前面に持ってきます", 5592405, 4473992)]
  public class Event2dAction_StandFrontMove : EventAction
  {
    [Token(Token = "0x40045C9")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x40045CA")]
    [FieldOffset(Offset = "0x1C")]
    private EventDialogBubbleCustom mBubble;

    [Token(Token = "0x6004F68")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004F69")]
    [Address(RVA = "0x12479F0", Offset = "0x12467F0", VA = "0x112479F0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F6A")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_StandFrontMove()
    {
    }
  }
}
