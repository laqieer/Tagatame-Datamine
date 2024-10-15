// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqLeagueMatchOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200175A")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("LeagueMatch/Req/LeagueMatchOption", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqLeagueMatchOption : FlowNode_Network
  {
    [Token(Token = "0x40053F3")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053F4")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x40053F5")]
    public const string KEY_LEAGUEMATCH_OPTION_SETTING = "KEY_LEAGUEMATCH_OPTION_SETTING";

    [Token(Token = "0x6005ED7")]
    [Address(RVA = "0x133FCB0", Offset = "0x133EAB0", VA = "0x1133FCB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005ED8")]
    [Address(RVA = "0x1340140", Offset = "0x133EF40", VA = "0x11340140")]
    private void Success()
    {
    }

    [Token(Token = "0x6005ED9")]
    [Address(RVA = "0x133FE70", Offset = "0x133EC70", VA = "0x1133FE70", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005EDA")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqLeagueMatchOption()
    {
    }

    [Token(Token = "0x200175B")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40053F6")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchOption.Response body;

      [Token(Token = "0x6005EDB")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
