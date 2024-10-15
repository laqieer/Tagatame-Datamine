// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_EndDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001287")]
  [EventActionInfo("会話/閉じる(2D)", "表示されている吹き出しを閉じます", 5592405, 4473992)]
  public class Event2dAction_EndDialog : EventAction
  {
    [Token(Token = "0x400448E")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string ActorID;
    [Token(Token = "0x400448F")]
    [FieldOffset(Offset = "0x1C")]
    private EventDialogBubbleCustom mBubble;

    [Token(Token = "0x6004E87")]
    [Address(RVA = "0x123D430", Offset = "0x123C230", VA = "0x1123D430", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E88")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_EndDialog()
    {
    }
  }
}
