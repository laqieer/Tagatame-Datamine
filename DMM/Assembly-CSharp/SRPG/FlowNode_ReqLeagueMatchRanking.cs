// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200175F")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("LeagueMatch/Req/LeagueMatchRanking", 32741)]
  public class FlowNode_ReqLeagueMatchRanking : FlowNode_Network
  {
    [Token(Token = "0x4005401")]
    public const string KEY_REQ_LEAGUEMATCH_RANKING = "KEY_REQ_LEAGUEMATCH_RANKING";
    [Token(Token = "0x4005402")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005403")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x6005EE8")]
    [Address(RVA = "0x1341030", Offset = "0x133FE30", VA = "0x11341030", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005EE9")]
    [Address(RVA = "0x13413E0", Offset = "0x13401E0", VA = "0x113413E0")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x6005EEA")]
    [Address(RVA = "0x1341110", Offset = "0x133FF10", VA = "0x11341110", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EEB")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchRanking()
    {
    }

    [Token(Token = "0x2001760")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005404")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchRanking.Response body;

      [Token(Token = "0x6005EEC")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
