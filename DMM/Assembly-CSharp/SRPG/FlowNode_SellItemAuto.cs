// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SellItemAuto
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
  [Token(Token = "0x2001606")]
  [FlowNode.NodeType("System/Shop/SellItemAuto", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(120, "ゼニー上限超えで売却不可", FlowNode.PinTypes.Output, 20)]
  [AddComponentMenu("")]
  public class FlowNode_SellItemAuto : FlowNode_Network
  {
    [Token(Token = "0x4004FDF")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004FE0")]
    private const int PIN_IN_REQUESTCONVERT = 2;
    [Token(Token = "0x4004FE1")]
    private const int PIN_OT_SUCCESS = 100;
    [Token(Token = "0x4004FE2")]
    private const int PIN_OT_SHOP_REACHED_MAX_ZENNY = 120;

    [Token(Token = "0x6005A93")]
    [Address(RVA = "0x12F4560", Offset = "0x12F3360", VA = "0x112F4560", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A94")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005A95")]
    [Address(RVA = "0x12F4630", Offset = "0x12F3430", VA = "0x112F4630", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005A96")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_SellItemAuto()
    {
    }

    [Token(Token = "0x2001607")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004FE3")]
      [FieldOffset(Offset = "0x28")]
      public ReqItemSellConvert.Response body;

      [Token(Token = "0x6005A98")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
