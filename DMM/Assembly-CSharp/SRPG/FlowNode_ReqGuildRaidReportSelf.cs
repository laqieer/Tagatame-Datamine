// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidReportSelf
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016E4")]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidReportSelf", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildRaidReportSelf : FlowNode_Network
  {
    [Token(Token = "0x40052C0")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052C1")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005D79")]
    [Address(RVA = "0x131F500", Offset = "0x131E300", VA = "0x1131F500", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D7A")]
    [Address(RVA = "0x131FC20", Offset = "0x131EA20", VA = "0x1131FC20")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D7B")]
    [Address(RVA = "0x131F7A0", Offset = "0x131E5A0", VA = "0x1131F7A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D7C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidReportSelf()
    {
    }

    [Token(Token = "0x20016E5")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052C2")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidReportSelf.Response body;

      [Token(Token = "0x6005D7D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
