// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGachaOptionSet_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B3C")]
  public sealed class FlowNode_ReqGachaOptionSet_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGachaOptionSet.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B08")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B09")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002B02")]
    [Address(RVA = "0xF5F770", Offset = "0xF5E570", VA = "0x10F5F770")]
    public FlowNode_ReqGachaOptionSet_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002B03")]
    [Address(RVA = "0xF5F480", Offset = "0xF5E280", VA = "0x10F5F480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGachaOptionSet.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002B04")]
    [Address(RVA = "0xF5F050", Offset = "0xF5DE50", VA = "0x10F5F050", Slot = "5")]
    public FlowNode_ReqGachaOptionSet.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGachaOptionSet.MP_Response) null;
    }
  }
}
