// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsOpenLeagueMatchRankingPeriod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001748")]
  [FlowNode.NodeType("LeagueMatch/IsOpenRankingPeriod", 32741)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "開催中", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(100, "エラー", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_IsOpenLeagueMatchRankingPeriod : FlowNode
  {
    [Token(Token = "0x40053BC")]
    private const int PIN_INPUT = 1;
    [Token(Token = "0x40053BD")]
    private const int PIN_OUTPUT_OPEN = 10;
    [Token(Token = "0x40053BE")]
    private const int PIN_OUTPUT_CLOSE = 11;
    [Token(Token = "0x40053BF")]
    private const int PIN_ERROR = 100;

    [Token(Token = "0x6005EA4")]
    [Address(RVA = "0x1330F60", Offset = "0x132FD60", VA = "0x11330F60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005EA5")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsOpenLeagueMatchRankingPeriod()
    {
    }
  }
}
