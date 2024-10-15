// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRoleBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016AB")]
  [FlowNode.Pin(200, "受け取れるRoleじゃない", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "報酬期間外", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Guild/Req/RoleBonus", 32741)]
  public class FlowNode_ReqGuildRoleBonus : FlowNode_Network
  {
    [Token(Token = "0x4005251")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005252")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005253")]
    private const int PIN_OUT_MASTER_ONLY = 200;
    [Token(Token = "0x4005254")]
    private const int PIN_OUT_OUT_OF_MASTER_REWARD_PERIOD = 201;
    [Token(Token = "0x4005255")]
    [FieldOffset(Offset = "0x0")]
    private static ReqGuildRoleBonus.Response mKeepResponse;

    [Token(Token = "0x6005CDB")]
    [Address(RVA = "0x130BCB0", Offset = "0x130AAB0", VA = "0x1130BCB0")]
    public static ReqGuildRoleBonus.Response GetResponse() => (ReqGuildRoleBonus.Response) null;

    [Token(Token = "0x6005CDC")]
    [Address(RVA = "0x130BBC0", Offset = "0x130A9C0", VA = "0x1130BBC0")]
    public static void Clear()
    {
    }

    [Token(Token = "0x6005CDD")]
    [Address(RVA = "0x130BCE0", Offset = "0x130AAE0", VA = "0x1130BCE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CDE")]
    [Address(RVA = "0x130BC00", Offset = "0x130AA00", VA = "0x1130BC00")]
    public ReqGuildRoleBonus.RequestParam CreateRequest() => (ReqGuildRoleBonus.RequestParam) null;

    [Token(Token = "0x6005CDF")]
    [Address(RVA = "0x130C310", Offset = "0x130B110", VA = "0x1130C310")]
    public void Success()
    {
    }

    [Token(Token = "0x6005CE0")]
    [Address(RVA = "0x130BE60", Offset = "0x130AC60", VA = "0x1130BE60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CE1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRoleBonus()
    {
    }

    [Token(Token = "0x20016AC")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005256")]
      [FieldOffset(Offset = "0x28")]
      public ReqGuildRoleBonus.Response body;

      [Token(Token = "0x6005CE2")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
