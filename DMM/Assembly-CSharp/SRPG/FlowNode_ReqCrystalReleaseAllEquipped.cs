// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCrystalReleaseAllEquipped
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001334")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Crystal/Req/CrystalReleaseAllEquipped", 32741)]
  public class FlowNode_ReqCrystalReleaseAllEquipped : FlowNode_Network
  {
    [Token(Token = "0x400472B")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400472C")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400472D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x60050E0")]
    [Address(RVA = "0x125C7E0", Offset = "0x125B5E0", VA = "0x1125C7E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60050E1")]
    [Address(RVA = "0x125CCA0", Offset = "0x125BAA0", VA = "0x1125CCA0")]
    private void Success()
    {
    }

    [Token(Token = "0x60050E2")]
    [Address(RVA = "0x125C9C0", Offset = "0x125B7C0", VA = "0x1125C9C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050E3")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCrystalReleaseAllEquipped()
    {
    }

    [Token(Token = "0x2001335")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response_Base : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400472E")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalReleaseAllEquipped.Response body;

      [Token(Token = "0x60050E4")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response_Base()
      {
      }
    }
  }
}
