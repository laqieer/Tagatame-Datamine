// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchPartySetName
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200175E")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("LeagueMatch/FlowNode_ReqLeagueMatchPartySetName", 32741)]
  public class FlowNode_ReqLeagueMatchPartySetName : FlowNode_Network
  {
    [Token(Token = "0x40053FD")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053FE")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x40053FF")]
    public const string KEY_LEAGUEMATCH_PARTYSETNAME_PARTY_NO = "KEY_LEAGUEMATCH_PARTYSETNAME_PARTY_NO";
    [Token(Token = "0x4005400")]
    public const string KEY_LEAGUEMATCH_PARTYSETNAME_NAME = "KEY_LEAGUEMATCH_PARTYSETNAME_NAME";

    [Token(Token = "0x6005EE4")]
    [Address(RVA = "0x13401B0", Offset = "0x133EFB0", VA = "0x113401B0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005EE5")]
    [Address(RVA = "0x1340500", Offset = "0x133F300", VA = "0x11340500")]
    private void Success()
    {
    }

    [Token(Token = "0x6005EE6")]
    [Address(RVA = "0x1340330", Offset = "0x133F130", VA = "0x11340330", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EE7")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchPartySetName()
    {
    }
  }
}
