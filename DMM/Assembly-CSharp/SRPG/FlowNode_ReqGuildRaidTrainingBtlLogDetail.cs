// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRaidTrainingBtlLogDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016F2")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("GuildRaid/Training/Req/GuildRaidTrainingBtlLogDetail", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuildRaidTrainingBtlLogDetail : FlowNode_Network
  {
    [Token(Token = "0x40052DE")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052DF")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40052E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool CanPost;

    [Token(Token = "0x6005D9E")]
    [Address(RVA = "0x1320400", Offset = "0x131F200", VA = "0x11320400", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D9F")]
    [Address(RVA = "0x1320A70", Offset = "0x131F870", VA = "0x11320A70")]
    private void Success()
    {
    }

    [Token(Token = "0x6005DA0")]
    [Address(RVA = "0x13205C0", Offset = "0x131F3C0", VA = "0x113205C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005DA1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRaidTrainingBtlLogDetail()
    {
    }

    [Token(Token = "0x20016F3")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052E1")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRaidTrainingBtlLogDetail.Response body;

      [Token(Token = "0x6005DA2")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
