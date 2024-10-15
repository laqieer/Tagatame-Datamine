// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUnitRentalLeave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018A9")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("UnitRental/Req/Leave", 32741)]
  public class FlowNode_ReqUnitRentalLeave : FlowNode_Network
  {
    [Token(Token = "0x400587D")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400587E")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6006334")]
    [Address(RVA = "0x312B30", Offset = "0x311930", VA = "0x10312B30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006335")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006336")]
    [Address(RVA = "0x312CA0", Offset = "0x311AA0", VA = "0x10312CA0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006337")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqUnitRentalLeave()
    {
    }

    [Token(Token = "0x20018AA")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400587F")]
      [FieldOffset(Offset = "0x28")]
      public ReqUnitRentalLeave.Response body;

      [Token(Token = "0x6006338")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
