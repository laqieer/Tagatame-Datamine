// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_SE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012A0")]
  [EventActionInfo("SE再生(2D)", "SEを再生します", 5592405, 4473992)]
  public class Event2dAction_SE : EventAction
  {
    [Token(Token = "0x4004539")]
    [FieldOffset(Offset = "0x18")]
    public string SE;

    [Token(Token = "0x6004EEB")]
    [Address(RVA = "0x1242C70", Offset = "0x1241A70", VA = "0x11242C70", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EEC")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_SE()
    {
    }
  }
}
