// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchDefenseBuff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200174E")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("LeagueMatch/Req/LeagueMatchDefenseBuff", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqLeagueMatchDefenseBuff : FlowNode_Network
  {
    [Token(Token = "0x40053D8")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053D9")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40053DA")]
    public const string KEY_LEAGUEMATCH_DEFENSE_BUFF_PARTY_NO = "KEY_LEAGUEMATCH_DEFENSE_BUFF_PARTY_NO";
    [Token(Token = "0x40053DB")]
    public const string KEY_LEAGUEMATCH_DEFENSE_BUFF = "KEY_LEAGUEMATCH_DEFENSE_BUFF";

    [Token(Token = "0x6005EB4")]
    [Address(RVA = "0x133C730", Offset = "0x133B530", VA = "0x1133C730", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005EB5")]
    [Address(RVA = "0x133CC10", Offset = "0x133BA10", VA = "0x1133CC10")]
    private void Success(SerializeValueList _value_list)
    {
    }

    [Token(Token = "0x6005EB6")]
    [Address(RVA = "0x133C8B0", Offset = "0x133B6B0", VA = "0x1133C8B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EB7")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchDefenseBuff()
    {
    }

    [Token(Token = "0x200174F")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40053DC")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchDefenseBuff.Response body;

      [Token(Token = "0x6005EB8")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
