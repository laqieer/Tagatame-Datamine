// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_DisableQuit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011FE")]
  [EventActionInfo("強制終了/禁止", "スクリプトの強制終了を無効にします。", 5592405, 4473992)]
  public class EventAction_DisableQuit : EventAction
  {
    [Token(Token = "0x6004C84")]
    [Address(RVA = "0x1219050", Offset = "0x1217E50", VA = "0x11219050", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C85")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_DisableQuit()
    {
    }
  }
}
