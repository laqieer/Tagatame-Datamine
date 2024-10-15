// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqHotDealGenerate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001316")]
  [FlowNode.NodeType("BuyCoin/HotDeal/Generate", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(110, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "Request", FlowNode.PinTypes.Input, 10)]
  public class FlowNode_ReqHotDealGenerate : FlowNode_Network
  {
    [Token(Token = "0x40046D7")]
    private const int PIN_INPUT_REQUEST = 10;
    [Token(Token = "0x40046D8")]
    private const int PIN_OUTPUT_SUCCESS = 100;
    [Token(Token = "0x40046D9")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 110;

    [Token(Token = "0x6005082")]
    [Address(RVA = "0x1261D60", Offset = "0x1260B60", VA = "0x11261D60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005083")]
    [Address(RVA = "0x1261E30", Offset = "0x1260C30", VA = "0x11261E30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005084")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqHotDealGenerate()
    {
    }

    [Token(Token = "0x2001317")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40046DA")]
      [FieldOffset(Offset = "0x28")]
      public ReqHotDealGenerate.Response body;

      [Token(Token = "0x6005086")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
