// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_StreamingMovieFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005F5")]
  public sealed class JSON_StreamingMovieFormatter : 
    IMessagePackFormatter<JSON_StreamingMovie>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001082")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001083")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B2D")]
    [Address(RVA = "0xBA9880", Offset = "0xBA8680", VA = "0x10BA9880")]
    public JSON_StreamingMovieFormatter()
    {
    }

    [Token(Token = "0x6001B2E")]
    [Address(RVA = "0xBA9730", Offset = "0xBA8530", VA = "0x10BA9730", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_StreamingMovie value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B2F")]
    [Address(RVA = "0xBA9400", Offset = "0xBA8200", VA = "0x10BA9400", Slot = "5")]
    public JSON_StreamingMovie Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_StreamingMovie) null;
    }
  }
}
