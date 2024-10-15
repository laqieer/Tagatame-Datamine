// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRunePrideBoardReset_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A18")]
  public sealed class ReqRunePrideBoardReset_ResponseFormatter : 
    IMessagePackFormatter<ReqRunePrideBoardReset.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018C0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018C1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002796")]
    [Address(RVA = "0xEA67D0", Offset = "0xEA55D0", VA = "0x10EA67D0")]
    public ReqRunePrideBoardReset_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002797")]
    [Address(RVA = "0xEA65C0", Offset = "0xEA53C0", VA = "0x10EA65C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRunePrideBoardReset.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002798")]
    [Address(RVA = "0xEA6240", Offset = "0xEA5040", VA = "0x10EA6240", Slot = "5")]
    public ReqRunePrideBoardReset.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRunePrideBoardReset.Response) null;
    }
  }
}
