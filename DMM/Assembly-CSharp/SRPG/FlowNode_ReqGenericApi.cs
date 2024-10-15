// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGenericApi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200150F")]
  [FlowNode.Pin(105, ">=", FlowNode.PinTypes.Input, 105)]
  [FlowNode.Pin(1000, "True", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1001, "False", FlowNode.PinTypes.Output, 1001)]
  [AddComponentMenu("")]
  [FlowNode.Pin(103, "<=", FlowNode.PinTypes.Input, 103)]
  [FlowNode.Pin(104, ">", FlowNode.PinTypes.Input, 104)]
  [FlowNode.Pin(102, "<", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(101, "!=", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(100, "==", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(0, "Request Only(API呼び出しに成功すると常にTrueを出力)", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/WebApi/Generic", 32741)]
  public class FlowNode_ReqGenericApi : FlowNode_Network
  {
    [Token(Token = "0x4004D20")]
    private const int PIN_IN_REQUEST_ONLY = 0;
    [Token(Token = "0x4004D21")]
    private const int PIN_IN_EQUAL = 100;
    [Token(Token = "0x4004D22")]
    private const int PIN_IN_NOT_EQUAL = 101;
    [Token(Token = "0x4004D23")]
    private const int PIN_IN_LESS_THAN = 102;
    [Token(Token = "0x4004D24")]
    private const int PIN_IN_LESS_THAN_OR_EQUAL = 103;
    [Token(Token = "0x4004D25")]
    private const int PIN_IN_GREATER_THAN = 104;
    [Token(Token = "0x4004D26")]
    private const int PIN_IN_GREATER_THAN_OR_EQUAL = 105;
    [Token(Token = "0x4004D27")]
    private const int PIN_OUT_TRUE = 1000;
    [Token(Token = "0x4004D28")]
    private const int PIN_OUT_FALSE = 1001;
    [Token(Token = "0x4004D29")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string ApiName;
    [Token(Token = "0x4004D2A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private FlowNode_ReqGenericApi.CompareTarget Compare_Target;
    [Token(Token = "0x4004D2B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string Text;
    [Token(Token = "0x4004D2C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int Number;
    [Token(Token = "0x4004D2D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string Time;
    [Token(Token = "0x4004D2E")]
    [FieldOffset(Offset = "0x34")]
    private int mPinId;

    [Token(Token = "0x600576C")]
    [Address(RVA = "0x12CEFC0", Offset = "0x12CDDC0", VA = "0x112CEFC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600576D")]
    [Address(RVA = "0x12CF0F0", Offset = "0x12CDEF0", VA = "0x112CF0F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600576E")]
    [Address(RVA = "0x12CEC10", Offset = "0x12CDA10", VA = "0x112CEC10")]
    private void Compare(FlowNode_ReqGenericApi.JSON_Response res)
    {
    }

    [Token(Token = "0x600576F")]
    [Address(RVA = "0x12CF1C0", Offset = "0x12CDFC0", VA = "0x112CF1C0")]
    public FlowNode_ReqGenericApi()
    {
    }

    [Token(Token = "0x2001510")]
    public enum CompareTarget
    {
      [Token(Token = "0x4004D30")] Text,
      [Token(Token = "0x4004D31")] Number,
      [Token(Token = "0x4004D32")] Time,
    }

    [Token(Token = "0x2001511")]
    private class JSON_Response
    {
      [Token(Token = "0x4004D33")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_ReqGenericApi.JSON_ResponseContents result;

      [Token(Token = "0x6005770")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_Response()
      {
      }
    }

    [Token(Token = "0x2001512")]
    private class JSON_ResponseContents
    {
      [Token(Token = "0x4004D34")]
      [FieldOffset(Offset = "0x8")]
      public string text;
      [Token(Token = "0x4004D35")]
      [FieldOffset(Offset = "0xC")]
      public int number;
      [Token(Token = "0x4004D36")]
      [FieldOffset(Offset = "0x10")]
      public long time;

      [Token(Token = "0x6005771")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_ResponseContents()
      {
      }
    }
  }
}
