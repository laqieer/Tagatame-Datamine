// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalReplace_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009F6")]
  public sealed class FlowNode_ReqCrystalReplace_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalReplace.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400187C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400187D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002730")]
    [Address(RVA = "0xE7DA50", Offset = "0xE7C850", VA = "0x10E7DA50")]
    public FlowNode_ReqCrystalReplace_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002731")]
    [Address(RVA = "0xE7D760", Offset = "0xE7C560", VA = "0x10E7D760", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalReplace.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002732")]
    [Address(RVA = "0xE7D330", Offset = "0xE7C130", VA = "0x10E7D330", Slot = "5")]
    public FlowNode_ReqCrystalReplace.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalReplace.MP_Response) null;
    }
  }
}
