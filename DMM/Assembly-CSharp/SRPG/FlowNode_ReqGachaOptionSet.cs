// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGachaOptionSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001678")]
  [FlowNode.NodeType("System/Gacha/OptionSet", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "OutOfPeriod", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGachaOptionSet : FlowNode_Network
  {
    [Token(Token = "0x40051BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GachaOption GachaOptionWindow;
    [Token(Token = "0x40051BF")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40051C0")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40051C1")]
    protected const int PIN_OUT_OUT_OF_PERIOD = 201;

    [Token(Token = "0x6005C41")]
    [Address(RVA = "0x1309300", Offset = "0x1308100", VA = "0x11309300", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C42")]
    [Address(RVA = "0x13091E0", Offset = "0x1307FE0", VA = "0x113091E0")]
    private bool IsSameOption() => new bool();

    [Token(Token = "0x6005C43")]
    [Address(RVA = "0x1309100", Offset = "0x1307F00", VA = "0x11309100")]
    private ReqGachaOptionSet.RequestParam CreateRequest() => (ReqGachaOptionSet.RequestParam) null;

    [Token(Token = "0x6005C44")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005C45")]
    [Address(RVA = "0x13095E0", Offset = "0x13083E0", VA = "0x113095E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005C46")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGachaOptionSet()
    {
    }

    [Token(Token = "0x2001679")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40051C2")]
      [FieldOffset(Offset = "0x28")]
      public ReqGachaOptionSet.Response body;

      [Token(Token = "0x6005C47")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
