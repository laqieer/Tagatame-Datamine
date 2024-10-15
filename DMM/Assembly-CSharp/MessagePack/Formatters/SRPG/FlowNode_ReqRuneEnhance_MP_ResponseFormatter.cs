// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneEnhance_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ABC")]
  public sealed class FlowNode_ReqRuneEnhance_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneEnhance.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A08")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A09")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002982")]
    [Address(RVA = "0xF0B6D0", Offset = "0xF0A4D0", VA = "0x10F0B6D0")]
    public FlowNode_ReqRuneEnhance_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002983")]
    [Address(RVA = "0xF0B3E0", Offset = "0xF0A1E0", VA = "0x10F0B3E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneEnhance.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002984")]
    [Address(RVA = "0xF0AFB0", Offset = "0xF09DB0", VA = "0x10F0AFB0", Slot = "5")]
    public FlowNode_ReqRuneEnhance.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneEnhance.MP_Response) null;
    }
  }
}
