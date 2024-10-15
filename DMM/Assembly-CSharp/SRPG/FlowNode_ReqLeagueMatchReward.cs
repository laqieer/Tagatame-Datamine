// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001761")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("LeagueMatch/FlowNode_ReqLeagueMatchReward", 32741)]
  public class FlowNode_ReqLeagueMatchReward : FlowNode_Network
  {
    [Token(Token = "0x4005405")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005406")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005407")]
    public const string KEY_LEAGUEMATCH_REWARD_DATA = "KEY_LEAGUEMATCH_REWARD_DATA";

    [Token(Token = "0x6005EED")]
    [Address(RVA = "0x1341460", Offset = "0x1340260", VA = "0x11341460", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005EEE")]
    [Address(RVA = "0x13417F0", Offset = "0x13405F0", VA = "0x113417F0")]
    private void Success(SerializeValueList _value_list)
    {
    }

    [Token(Token = "0x6005EEF")]
    [Address(RVA = "0x1341540", Offset = "0x1340340", VA = "0x11341540", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EF0")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchReward()
    {
    }
  }
}
