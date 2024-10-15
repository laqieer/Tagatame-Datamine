// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_DialogAsync
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011FD")]
  [EventActionInfo("会話/表示 (非同期)", "会話の文章を表示します。", 5592456, 5592490)]
  public class EventAction_DialogAsync : EventAction_Dialog
  {
    [Token(Token = "0x6004C81")]
    [Address(RVA = "0x1217F50", Offset = "0x1216D50", VA = "0x11217F50", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C82")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "18")]
    protected override void OnFinish()
    {
    }

    [Token(Token = "0x6004C83")]
    [Address(RVA = "0x1217F70", Offset = "0x1216D70", VA = "0x11217F70")]
    public EventAction_DialogAsync()
    {
    }
  }
}
