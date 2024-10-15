// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidRankingPort
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016DB")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidRankingPort", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuildRaidRankingPort : FlowNode_Network
  {
    [Token(Token = "0x40052AE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool Overwrite;
    [Token(Token = "0x40052AF")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052B0")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D61")]
    [Address(RVA = "0x131D7A0", Offset = "0x131C5A0", VA = "0x1131D7A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D62")]
    [Address(RVA = "0x131E000", Offset = "0x131CE00", VA = "0x1131E000")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D63")]
    [Address(RVA = "0x131DA20", Offset = "0x131C820", VA = "0x1131DA20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D64")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidRankingPort()
    {
    }

    [Token(Token = "0x20016DC")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052B1")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidRankingPort.Response body;

      [Token(Token = "0x6005D65")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
