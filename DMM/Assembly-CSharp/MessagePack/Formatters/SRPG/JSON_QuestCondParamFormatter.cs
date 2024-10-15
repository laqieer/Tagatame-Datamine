// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A4F")]
  public sealed class JSON_QuestCondParamFormatter : 
    IMessagePackFormatter<JSON_QuestCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400192E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400192F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600283B")]
    [Address(RVA = "0xEB0FF0", Offset = "0xEAFDF0", VA = "0x10EB0FF0")]
    public JSON_QuestCondParamFormatter()
    {
    }

    [Token(Token = "0x600283C")]
    [Address(RVA = "0xEB0830", Offset = "0xEAF630", VA = "0x10EB0830", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600283D")]
    [Address(RVA = "0xEAFEA0", Offset = "0xEAECA0", VA = "0x10EAFEA0", Slot = "5")]
    public JSON_QuestCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestCondParam) null;
    }
  }
}
