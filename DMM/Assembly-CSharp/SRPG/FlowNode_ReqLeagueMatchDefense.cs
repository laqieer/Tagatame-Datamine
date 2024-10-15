// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchDefense
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200174C")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("LeagueMatch/Req/LeagueMatchDefense", 32741)]
  public class FlowNode_ReqLeagueMatchDefense : FlowNode_Network
  {
    [Token(Token = "0x40053D1")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053D2")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40053D3")]
    public const string KEY_LEAGUEMATCH_DEFENSE_PARTY_NO = "KEY_LEAGUEMATCH_DEFENSE_PARTY_NO";
    [Token(Token = "0x40053D4")]
    public const string KEY_LEAGUEMATCH_DEFENSE_UNITS = "KEY_LEAGUEMATCH_DEFENSE_UNITS";
    [Token(Token = "0x40053D5")]
    public const string KEY_LEAGUEMATCH_DEFENSE_MAP = "KEY_LEAGUEMATCH_DEFENSE_MAP";
    [Token(Token = "0x40053D6")]
    public const string KEY_LEAGUEMATCH_DEFENSE_PLACEMENT = "KEY_LEAGUEMATCH_DEFENSE_PLACEMENT";

    [Token(Token = "0x6005EAF")]
    [Address(RVA = "0x133D5C0", Offset = "0x133C3C0", VA = "0x1133D5C0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005EB0")]
    [Address(RVA = "0x133DCF0", Offset = "0x133CAF0", VA = "0x1133DCF0")]
    private void Success(SerializeValueList _value_list)
    {
    }

    [Token(Token = "0x6005EB1")]
    [Address(RVA = "0x133D980", Offset = "0x133C780", VA = "0x1133D980", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EB2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchDefense()
    {
    }

    [Token(Token = "0x200174D")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40053D7")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchDefense.Response body;

      [Token(Token = "0x6005EB3")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
