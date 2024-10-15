// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchShamBuff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001764")]
  [FlowNode.NodeType("LeagueMatch/Req/LeagueMatchShamBuff", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqLeagueMatchShamBuff : FlowNode_Network
  {
    [Token(Token = "0x400540E")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400540F")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005410")]
    public const string KEY_LEAGUEMATCH_SHAM_DEFENSE_BUFF = "KEY_LEAGUEMATCH_SHAM_DEFENSE_BUFF";

    [Token(Token = "0x6005EF6")]
    [Address(RVA = "0x1341870", Offset = "0x1340670", VA = "0x11341870", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005EF7")]
    [Address(RVA = "0x1341CF0", Offset = "0x1340AF0", VA = "0x11341CF0")]
    private void Success(SerializeValueList _value_list)
    {
    }

    [Token(Token = "0x6005EF8")]
    [Address(RVA = "0x13419E0", Offset = "0x13407E0", VA = "0x113419E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EF9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchShamBuff()
    {
    }

    [Token(Token = "0x2001765")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005411")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchBattleShamBuff.Response body;

      [Token(Token = "0x6005EFA")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
