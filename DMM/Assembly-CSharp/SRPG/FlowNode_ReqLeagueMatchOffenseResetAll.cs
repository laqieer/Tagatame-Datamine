// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchOffenseResetAll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001759")]
  [FlowNode.NodeType("LeagueMatch/FlowNode_ReqLeagueMatchOffenseResetAll", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqLeagueMatchOffenseResetAll : FlowNode_Network
  {
    [Token(Token = "0x40053F1")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053F2")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x6005ED3")]
    [Address(RVA = "0x133F290", Offset = "0x133E090", VA = "0x1133F290", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005ED4")]
    [Address(RVA = "0x133F6E0", Offset = "0x133E4E0", VA = "0x1133F6E0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005ED5")]
    [Address(RVA = "0x133F370", Offset = "0x133E170", VA = "0x1133F370", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005ED6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchOffenseResetAll()
    {
    }
  }
}
