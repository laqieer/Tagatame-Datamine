// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchSham
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001762")]
  [FlowNode.NodeType("LeagueMatch/Req/LeagueMatchSham", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqLeagueMatchSham : FlowNode_Network
  {
    [Token(Token = "0x4005408")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005409")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400540A")]
    public const string KEY_LEAGUEMATCH_SHAM_UNITS = "KEY_LEAGUEMATCH_SHAM_UNITS";
    [Token(Token = "0x400540B")]
    public const string KEY_LEAGUEMATCH_SHAM_MAP = "KEY_LEAGUEMATCH_SHAM_MAP";
    [Token(Token = "0x400540C")]
    public const string KEY_LEAGUEMATCH_SHAM_PLACEMENT = "KEY_LEAGUEMATCH_SHAM_PLACEMENT";

    [Token(Token = "0x6005EF1")]
    [Address(RVA = "0x1341D70", Offset = "0x1340B70", VA = "0x11341D70", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005EF2")]
    [Address(RVA = "0x1342470", Offset = "0x1341270", VA = "0x11342470")]
    private void Success(SerializeValueList _value_list)
    {
    }

    [Token(Token = "0x6005EF3")]
    [Address(RVA = "0x1342100", Offset = "0x1340F00", VA = "0x11342100", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EF4")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchSham()
    {
    }

    [Token(Token = "0x2001763")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400540D")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchBattleShamEntry.Response body;

      [Token(Token = "0x6005EF5")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
