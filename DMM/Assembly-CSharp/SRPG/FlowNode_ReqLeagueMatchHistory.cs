// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001753")]
  [FlowNode.NodeType("LeagueMatch/Req/LeagueMatchHistory", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqLeagueMatchHistory : FlowNode_Network
  {
    [Token(Token = "0x40053E3")]
    public const string KEY_REQ_HISTORY_PAGE_ID = "KEY_REQ_HISTORY_PAGE_ID";
    [Token(Token = "0x40053E4")]
    public const string KEY_REQ_LEAGUEMATCH_HISTORY = "KEY_REQ_LEAGUEMATCH_HISTORY";
    [Token(Token = "0x40053E5")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053E6")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x6005EC2")]
    [Address(RVA = "0x133E220", Offset = "0x133D020", VA = "0x1133E220", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005EC3")]
    [Address(RVA = "0x133EC50", Offset = "0x133DA50", VA = "0x1133EC50")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x6005EC4")]
    [Address(RVA = "0x133E340", Offset = "0x133D140", VA = "0x1133E340", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EC5")]
    [Address(RVA = "0x133E630", Offset = "0x133D430", VA = "0x1133E630")]
    private JSON_LeagueMatchHistory[] SetNpcPartyData(JSON_LeagueMatchHistory[] histories)
    {
      return (JSON_LeagueMatchHistory[]) null;
    }

    [Token(Token = "0x6005EC6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchHistory()
    {
    }

    [Token(Token = "0x2001754")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40053E7")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchHistory.Response body;

      [Token(Token = "0x6005EC7")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
