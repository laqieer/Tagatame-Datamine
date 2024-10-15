// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCrystalDisassemble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200132D")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Crystal/Req/CrystalDisassemble", 32741)]
  public class FlowNode_ReqCrystalDisassemble : FlowNode_Network
  {
    [Token(Token = "0x400471B")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400471C")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60050CE")]
    [Address(RVA = "0x125B240", Offset = "0x125A040", VA = "0x1125B240", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60050CF")]
    [Address(RVA = "0x125B7E0", Offset = "0x125A5E0", VA = "0x1125B7E0")]
    private void Success()
    {
    }

    [Token(Token = "0x60050D0")]
    [Address(RVA = "0x125B380", Offset = "0x125A180", VA = "0x1125B380", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050D1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCrystalDisassemble()
    {
    }

    [Token(Token = "0x200132E")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400471D")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalDisassemble.Response body;

      [Token(Token = "0x60050D2")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
