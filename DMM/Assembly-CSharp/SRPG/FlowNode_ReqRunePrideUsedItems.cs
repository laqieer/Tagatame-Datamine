// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRunePrideUsedItems
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
  [Token(Token = "0x2001866")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("RunePride/Req/ReqRunePrideUsedItems", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqRunePrideUsedItems : FlowNode_Network
  {
    [Token(Token = "0x400577F")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005780")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005781")]
    public const string KEY_UNIT_ID = "KEY_UNIT_ID";
    [Token(Token = "0x4005782")]
    public const string KEY_USEDITEM_ID = "KEY_USEDITEM_ID";
    [Token(Token = "0x4005783")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;

    [Token(Token = "0x6006268")]
    [Address(RVA = "0x30B190", Offset = "0x309F90", VA = "0x1030B190")]
    private ReqRunePrideUsedItems.RequestParam CreateReqRunePrideUsedItems(
      SerializeValueList _valueList)
    {
      return (ReqRunePrideUsedItems.RequestParam) null;
    }

    [Token(Token = "0x6006269")]
    [Address(RVA = "0x30B220", Offset = "0x30A020", VA = "0x1030B220", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600626A")]
    [Address(RVA = "0x30B700", Offset = "0x30A500", VA = "0x1030B700")]
    private void Success(SerializeValueList _valueList = null)
    {
    }

    [Token(Token = "0x600626B")]
    [Address(RVA = "0x30B390", Offset = "0x30A190", VA = "0x1030B390", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600626C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRunePrideUsedItems()
    {
    }

    [Token(Token = "0x2001867")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005784")]
      [FieldOffset(Offset = "0x28")]
      public ReqRunePrideUsedItems.Response body;

      [Token(Token = "0x600626D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
