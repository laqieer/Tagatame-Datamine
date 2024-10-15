// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCrystalUnitSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200133C")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Crystal/Req/CrystalUnitSet", 32741)]
  public class FlowNode_ReqCrystalUnitSet : FlowNode_Network
  {
    [Token(Token = "0x400473B")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400473C")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60050F4")]
    [Address(RVA = "0x125DD70", Offset = "0x125CB70", VA = "0x1125DD70", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60050F5")]
    [Address(RVA = "0x125E870", Offset = "0x125D670", VA = "0x1125E870")]
    private void Success()
    {
    }

    [Token(Token = "0x60050F6")]
    [Address(RVA = "0x125E0C0", Offset = "0x125CEC0", VA = "0x1125E0C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050F7")]
    [Address(RVA = "0x125E4B0", Offset = "0x125D2B0", VA = "0x1125E4B0")]
    private void Success_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x60050F8")]
    [Address(RVA = "0x125E180", Offset = "0x125CF80", VA = "0x1125E180")]
    private void Success_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x60050F9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCrystalUnitSet()
    {
    }

    [Token(Token = "0x200133D")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response_Base : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400473D")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalUnitSet.Response body;

      [Token(Token = "0x60050FA")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response_Base()
      {
      }
    }

    [Token(Token = "0x200133E")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response_OverWrite : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400473E")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalSetDeck.Response body;

      [Token(Token = "0x60050FB")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response_OverWrite()
      {
      }
    }
  }
}
