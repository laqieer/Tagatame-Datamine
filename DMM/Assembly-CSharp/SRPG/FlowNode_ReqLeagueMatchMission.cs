// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001756")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("LeagueMatch/Req/LeagueMatchMission", 32741)]
  public class FlowNode_ReqLeagueMatchMission : FlowNode_Network
  {
    [Token(Token = "0x40053E9")]
    public const string KEY_LEAGUEMATCH_MISSION_INAMES = "KEY_LEAGUEMATCH_MISSION_INAMES";
    [Token(Token = "0x40053EA")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053EB")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x6005ECA")]
    [Address(RVA = "0x133ECD0", Offset = "0x133DAD0", VA = "0x1133ECD0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x6005ECB")]
    [Address(RVA = "0x133F210", Offset = "0x133E010", VA = "0x1133F210")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x6005ECC")]
    [Address(RVA = "0x133EEA0", Offset = "0x133DCA0", VA = "0x1133EEA0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005ECD")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchMission()
    {
    }

    [Token(Token = "0x2001757")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40053EC")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchMission.Response body;

      [Token(Token = "0x6005ECE")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
