// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRecoverMonthly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200176A")]
  [AddComponentMenu("")]
  [FlowNode.Pin(23, "CanNotRecoverFuture", FlowNode.PinTypes.Output, 23)]
  [FlowNode.Pin(21, "RemainRecoverShort", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(20, "OutOfPeriod", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(22, "AlreadyReceived", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("LoginBonus/Req/Recover", 32741)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_ReqRecoverMonthly : FlowNode_Network
  {
    [Token(Token = "0x400541F")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4005420")]
    private const int PIN_OT_SUCCESS = 10;
    [Token(Token = "0x4005421")]
    private const int PIN_OT_OUT_OF_PERIOD = 20;
    [Token(Token = "0x4005422")]
    private const int PIN_OT_REMAIN_RECOVER_SHORT = 21;
    [Token(Token = "0x4005423")]
    private const int PIN_OT_ALREADY_RECEIVED = 22;
    [Token(Token = "0x4005424")]
    private const int PIN_OT_CAN_NOT_RECOVER_FUTURE = 23;

    [Token(Token = "0x6005F07")]
    [Address(RVA = "0x13441E0", Offset = "0x1342FE0", VA = "0x113441E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F08")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F09")]
    [Address(RVA = "0x1344370", Offset = "0x1343170", VA = "0x11344370", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F0A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRecoverMonthly()
    {
    }

    [Token(Token = "0x200176B")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005425")]
      [FieldOffset(Offset = "0x28")]
      public ReqMonthlyRecover.Response body;

      [Token(Token = "0x6005F0B")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
