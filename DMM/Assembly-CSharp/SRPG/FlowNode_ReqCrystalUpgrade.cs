// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCrystalUpgrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200133F")]
  [FlowNode.NodeType("Crystal/Req/CrystalUpgrade", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqCrystalUpgrade : FlowNode_Network
  {
    [Token(Token = "0x400473F")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004740")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60050FC")]
    [Address(RVA = "0x125E8E0", Offset = "0x125D6E0", VA = "0x1125E8E0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60050FD")]
    [Address(RVA = "0x125EDD0", Offset = "0x125DBD0", VA = "0x1125EDD0")]
    private void Success()
    {
    }

    [Token(Token = "0x60050FE")]
    [Address(RVA = "0x125EA30", Offset = "0x125D830", VA = "0x1125EA30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050FF")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCrystalUpgrade()
    {
    }

    [Token(Token = "0x2001340")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004741")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalUpgrade.Response body;

      [Token(Token = "0x6005100")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
