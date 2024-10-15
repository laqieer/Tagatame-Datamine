// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TwitterMessageDetailParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000668")]
  public sealed class JSON_TwitterMessageDetailParamFormatter : 
    IMessagePackFormatter<JSON_TwitterMessageDetailParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001168")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001169")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C86")]
    [Address(RVA = "0xBF11C0", Offset = "0xBEFFC0", VA = "0x10BF11C0")]
    public JSON_TwitterMessageDetailParamFormatter()
    {
    }

    [Token(Token = "0x6001C87")]
    [Address(RVA = "0xBF1000", Offset = "0xBEFE00", VA = "0x10BF1000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TwitterMessageDetailParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C88")]
    [Address(RVA = "0xBF0C50", Offset = "0xBEFA50", VA = "0x10BF0C50", Slot = "5")]
    public JSON_TwitterMessageDetailParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TwitterMessageDetailParam) null;
    }
  }
}
