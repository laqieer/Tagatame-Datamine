// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchEnemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001752")]
  [FlowNode.NodeType("LeagueMatch/FlowNode_ReqLeagueMatchEnemy", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqLeagueMatchEnemy : FlowNode_Network
  {
    [Token(Token = "0x40053E1")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053E2")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x6005EBE")]
    [Address(RVA = "0x133DD70", Offset = "0x133CB70", VA = "0x1133DD70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005EBF")]
    [Address(RVA = "0x133E1B0", Offset = "0x133CFB0", VA = "0x1133E1B0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005EC0")]
    [Address(RVA = "0x133DED0", Offset = "0x133CCD0", VA = "0x1133DED0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EC1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchEnemy()
    {
    }
  }
}
