// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCrystalSale
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200133A")]
  [FlowNode.NodeType("Crystal/Req/CrystalSale", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqCrystalSale : FlowNode_Network
  {
    [Token(Token = "0x4004738")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004739")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60050EF")]
    [Address(RVA = "0x125D7E0", Offset = "0x125C5E0", VA = "0x1125D7E0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60050F0")]
    [Address(RVA = "0x125DD00", Offset = "0x125CB00", VA = "0x1125DD00")]
    private void Success()
    {
    }

    [Token(Token = "0x60050F1")]
    [Address(RVA = "0x125D910", Offset = "0x125C710", VA = "0x1125D910", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050F2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCrystalSale()
    {
    }

    [Token(Token = "0x200133B")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400473A")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalSale.Response body;

      [Token(Token = "0x60050F3")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
