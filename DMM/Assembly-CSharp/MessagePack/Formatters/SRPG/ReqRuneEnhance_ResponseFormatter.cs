// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneEnhance_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000990")]
  public sealed class ReqRuneEnhance_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneEnhance.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017B0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017B1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025FE")]
    [Address(RVA = "0xE443B0", Offset = "0xE431B0", VA = "0x10E443B0")]
    public ReqRuneEnhance_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025FF")]
    [Address(RVA = "0xE440B0", Offset = "0xE42EB0", VA = "0x10E440B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneEnhance.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002600")]
    [Address(RVA = "0xE43C70", Offset = "0xE42A70", VA = "0x10E43C70", Slot = "5")]
    public ReqRuneEnhance.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneEnhance.Response) null;
    }
  }
}
