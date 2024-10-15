// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUnitRentalAdd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018A5")]
  [FlowNode.NodeType("UnitRental/Req/Add", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqUnitRentalAdd : FlowNode_Network
  {
    [Token(Token = "0x4005876")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005877")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x600632A")]
    [Address(RVA = "0x312160", Offset = "0x310F60", VA = "0x10312160", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600632B")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x600632C")]
    [Address(RVA = "0x3122D0", Offset = "0x3110D0", VA = "0x103122D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600632D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqUnitRentalAdd()
    {
    }

    [Token(Token = "0x20018A6")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005878")]
      [FieldOffset(Offset = "0x28")]
      public ReqUnitRentalAdd.Response body;

      [Token(Token = "0x600632E")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
