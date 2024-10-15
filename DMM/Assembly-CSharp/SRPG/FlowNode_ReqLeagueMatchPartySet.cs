// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchPartySet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200175D")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("LeagueMatch/FlowNode_ReqLeagueMatchPartySet", 32741)]
  public class FlowNode_ReqLeagueMatchPartySet : FlowNode_Network
  {
    [Token(Token = "0x40053F9")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053FA")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x40053FB")]
    public const string KEY_LEAGUEMATCH_PARTYSET_PARTY_NO = "KEY_LEAGUEMATCH_PARTYSET_PARTY_NO";
    [Token(Token = "0x40053FC")]
    public const string KEY_LEAGUEMATCH_PARTYSET_UNITS = "KEY_LEAGUEMATCH_PARTYSET_UNITS";

    [Token(Token = "0x6005EE0")]
    [Address(RVA = "0x1340570", Offset = "0x133F370", VA = "0x11340570", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005EE1")]
    [Address(RVA = "0x1340AB0", Offset = "0x133F8B0", VA = "0x11340AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005EE2")]
    [Address(RVA = "0x13406F0", Offset = "0x133F4F0", VA = "0x113406F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EE3")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchPartySet()
    {
    }
  }
}
