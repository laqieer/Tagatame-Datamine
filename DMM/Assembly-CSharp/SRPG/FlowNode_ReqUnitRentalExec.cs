// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUnitRentalExec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018A7")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("UnitRental/Req/Exec", 32741)]
  [FlowNode.Pin(201, "OutOfPeriod", FlowNode.PinTypes.Output, 201)]
  public class FlowNode_ReqUnitRentalExec : FlowNode_Network
  {
    [Token(Token = "0x4005879")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400587A")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400587B")]
    protected const int PIN_OUT_OUT_OF_PERIOD = 201;

    [Token(Token = "0x600632F")]
    [Address(RVA = "0x3126C0", Offset = "0x3114C0", VA = "0x103126C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006330")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006331")]
    [Address(RVA = "0x3127C0", Offset = "0x3115C0", VA = "0x103127C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006332")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqUnitRentalExec()
    {
    }

    [Token(Token = "0x20018A8")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400587C")]
      [FieldOffset(Offset = "0x28")]
      public ReqUnitRentalExec.Response body;

      [Token(Token = "0x6006333")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
