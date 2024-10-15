// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200174A")]
  [FlowNode.NodeType("LeagueMatch/FlowNode_ReqLeagueMatchBattleStart", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqLeagueMatchBattleStart : FlowNode_Network
  {
    [Token(Token = "0x40053CB")]
    public const string KEY_LEAGUEMATCH_ENEMY_FUID = "KEY_LEAGUEMATCH_ENEMY_FUID";
    [Token(Token = "0x40053CC")]
    public const string KEY_LEAGUEMATCH_PARTY_NO = "KEY_LEAGUEMATCH_PARTY_NO";
    [Token(Token = "0x40053CD")]
    public const string KEY_LEAGUEMATCH_IS_NPC = "KEY_LEAGUEMATCH_IS_NPC";
    [Token(Token = "0x40053CE")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053CF")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x6005EA9")]
    [Address(RVA = "0x133BD30", Offset = "0x133AB30", VA = "0x1133BD30", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x6005EAA")]
    [Address(RVA = "0x133C6B0", Offset = "0x133B4B0", VA = "0x1133C6B0")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x6005EAB")]
    [Address(RVA = "0x133BF20", Offset = "0x133AD20", VA = "0x1133BF20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EAC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchBattleStart()
    {
    }
  }
}
