// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200175C")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("LeagueMatch/FlowNode_ReqLeagueMatchParty", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqLeagueMatchParty : FlowNode_Network
  {
    [Token(Token = "0x40053F7")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053F8")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x6005EDC")]
    [Address(RVA = "0x1340B20", Offset = "0x133F920", VA = "0x11340B20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005EDD")]
    [Address(RVA = "0x1340FC0", Offset = "0x133FDC0", VA = "0x11340FC0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005EDE")]
    [Address(RVA = "0x1340C00", Offset = "0x133FA00", VA = "0x11340C00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EDF")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchParty()
    {
    }
  }
}
