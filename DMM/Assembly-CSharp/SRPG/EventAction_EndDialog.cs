// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_EndDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001201")]
  [EventActionInfo("会話/閉じる", "表示されている吹き出しを閉じます", 5592456, 5592490)]
  public class EventAction_EndDialog : EventAction
  {
    [Token(Token = "0x4004187")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string ActorID;

    [Token(Token = "0x6004C95")]
    [Address(RVA = "0x1219820", Offset = "0x1218620", VA = "0x11219820", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C96")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_EndDialog()
    {
    }
  }
}
