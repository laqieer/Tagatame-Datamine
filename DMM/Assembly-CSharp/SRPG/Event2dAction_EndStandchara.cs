// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_EndStandchara
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001289")]
  [EventActionInfo("立ち絵/立ち絵消去(2D)", "表示されている立ち絵を消します", 5592405, 4473992)]
  public class Event2dAction_EndStandchara : EventAction
  {
    [Token(Token = "0x4004498")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;

    [Token(Token = "0x6004E8D")]
    [Address(RVA = "0x123D8B0", Offset = "0x123C6B0", VA = "0x1123D8B0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E8E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004E8F")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_EndStandchara()
    {
    }
  }
}
