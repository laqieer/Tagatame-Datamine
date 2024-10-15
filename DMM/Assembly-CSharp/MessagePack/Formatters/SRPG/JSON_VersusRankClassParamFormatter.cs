// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusRankClassParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200091C")]
  public sealed class JSON_VersusRankClassParamFormatter : 
    IMessagePackFormatter<JSON_VersusRankClassParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016C8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016C9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024A2")]
    [Address(RVA = "0xE017C0", Offset = "0xE005C0", VA = "0x10E017C0")]
    public JSON_VersusRankClassParamFormatter()
    {
    }

    [Token(Token = "0x60024A3")]
    [Address(RVA = "0xE01470", Offset = "0xE00270", VA = "0x10E01470", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusRankClassParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024A4")]
    [Address(RVA = "0xE00F30", Offset = "0xDFFD30", VA = "0x10E00F30", Slot = "5")]
    public JSON_VersusRankClassParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusRankClassParam) null;
    }
  }
}
