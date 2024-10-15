// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchDefenseEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001750")]
  [FlowNode.NodeType("LeagueMatch/Req/LeagueMatchDefenseEntry", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqLeagueMatchDefenseEntry : FlowNode_Network
  {
    [Token(Token = "0x40053DD")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053DE")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40053DF")]
    public const string KEY_LEAGUEMATCH_DEFENSE_ENTRY_PARTIES = "KEY_LEAGUEMATCH_DEFENSE_ENTRY_PARTIES";

    [Token(Token = "0x6005EB9")]
    [Address(RVA = "0x133CC90", Offset = "0x133BA90", VA = "0x1133CC90", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005EBA")]
    [Address(RVA = "0x133D540", Offset = "0x133C340", VA = "0x1133D540")]
    private void Success(SerializeValueList _value_list)
    {
    }

    [Token(Token = "0x6005EBB")]
    [Address(RVA = "0x133D1D0", Offset = "0x133BFD0", VA = "0x1133D1D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EBC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchDefenseEntry()
    {
    }

    [Token(Token = "0x2001751")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40053E0")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchDefenseEntry.Response body;

      [Token(Token = "0x6005EBD")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
