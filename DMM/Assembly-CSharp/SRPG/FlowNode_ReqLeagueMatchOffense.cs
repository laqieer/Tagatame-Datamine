// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchOffense
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001758")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("LeagueMatch/FlowNode_ReqLeagueMatchOffense", 32741)]
  public class FlowNode_ReqLeagueMatchOffense : FlowNode_Network
  {
    [Token(Token = "0x40053ED")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053EE")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x40053EF")]
    public const string KEY_LEAGUEMATCH_OFFENSE_PARTY_NO = "KEY_LEAGUEMATCH_OFFENSE_PARTY_NO";
    [Token(Token = "0x40053F0")]
    public const string KEY_LEAGUEMATCH_OFFENSE_UNITS = "KEY_LEAGUEMATCH_OFFENSE_UNITS";

    [Token(Token = "0x6005ECF")]
    [Address(RVA = "0x133F750", Offset = "0x133E550", VA = "0x1133F750", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005ED0")]
    [Address(RVA = "0x133FC30", Offset = "0x133EA30", VA = "0x1133FC30")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x6005ED1")]
    [Address(RVA = "0x133F8D0", Offset = "0x133E6D0", VA = "0x1133F8D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005ED2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchOffense()
    {
    }
  }
}
