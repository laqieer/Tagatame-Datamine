// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGPGSDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200169E")]
  [FlowNode.NodeType("GPGS/ReqDevice", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(300, "Retry", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(200, "Failed", FlowNode.PinTypes.Output, 200)]
  public class FlowNode_ReqGPGSDevice : FlowNode_Network
  {
    [Token(Token = "0x400522E")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400522F")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005230")]
    private const int PIN_OUT_FAILED = 200;
    [Token(Token = "0x4005231")]
    private const int PIN_OUT_RETRY = 300;

    [Token(Token = "0x6005CB6")]
    [Address(RVA = "0x1308A00", Offset = "0x1307800", VA = "0x11308A00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CB7")]
    [Address(RVA = "0x1308C00", Offset = "0x1307A00", VA = "0x11308C00")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CB8")]
    [Address(RVA = "0x1308A50", Offset = "0x1307850", VA = "0x11308A50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CB9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGPGSDevice()
    {
    }

    [Token(Token = "0x200169F")]
    [MessagePackObject(true)]
    [Serializable]
    public class DeviceResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005232")]
      [FieldOffset(Offset = "0x28")]
      public ReqGPGSDevice.Response body;

      [Token(Token = "0x6005CBA")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public DeviceResponse()
      {
      }
    }
  }
}
