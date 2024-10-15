// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCrystalBulkUpgrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200132B")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Crystal/Req/CrystalBulkUpgrade", 32741)]
  public class FlowNode_ReqCrystalBulkUpgrade : FlowNode_Network
  {
    [Token(Token = "0x4004718")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004719")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60050C9")]
    [Address(RVA = "0x125ACC0", Offset = "0x1259AC0", VA = "0x1125ACC0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60050CA")]
    [Address(RVA = "0x125B1D0", Offset = "0x1259FD0", VA = "0x1125B1D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60050CB")]
    [Address(RVA = "0x125ADF0", Offset = "0x1259BF0", VA = "0x1125ADF0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050CC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCrystalBulkUpgrade()
    {
    }

    [Token(Token = "0x200132C")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400471A")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalBulkUpgrade.Response body;

      [Token(Token = "0x60050CD")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
