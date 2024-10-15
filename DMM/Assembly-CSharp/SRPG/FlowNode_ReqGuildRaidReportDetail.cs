// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidReportDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016E1")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GuildRaid/Req/GuildRaidReportDetail", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildRaidReportDetail : FlowNode_Network
  {
    [Token(Token = "0x40052BA")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052BB")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40052BC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool CanPost;

    [Token(Token = "0x6005D71")]
    [Address(RVA = "0x131E930", Offset = "0x131D730", VA = "0x1131E930", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D72")]
    [Address(RVA = "0x131EFC0", Offset = "0x131DDC0", VA = "0x1131EFC0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005D73")]
    [Address(RVA = "0x131EB30", Offset = "0x131D930", VA = "0x1131EB30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005D74")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidReportDetail()
    {
    }

    [Token(Token = "0x20016E2")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052BD")]
      [FieldOffset(Offset = "0x28")]
      public JSON_GuildRaidReport body;

      [Token(Token = "0x6005D75")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
