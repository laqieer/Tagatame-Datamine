// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ChapterParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000861")]
  public sealed class JSON_ChapterParamFormatter : 
    IMessagePackFormatter<JSON_ChapterParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001552")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001553")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002271")]
    [Address(RVA = "0xD874C0", Offset = "0xD862C0", VA = "0x10D874C0")]
    public JSON_ChapterParamFormatter()
    {
    }

    [Token(Token = "0x6002272")]
    [Address(RVA = "0xD86DC0", Offset = "0xD85BC0", VA = "0x10D86DC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ChapterParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002273")]
    [Address(RVA = "0xD86570", Offset = "0xD85370", VA = "0x10D86570", Slot = "5")]
    public JSON_ChapterParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ChapterParam) null;
    }
  }
}
