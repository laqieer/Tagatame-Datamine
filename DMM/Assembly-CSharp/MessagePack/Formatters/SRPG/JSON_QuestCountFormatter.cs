// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestCountFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200072C")]
  public sealed class JSON_QuestCountFormatter : 
    IMessagePackFormatter<JSON_QuestCount>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012F0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012F1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001ED2")]
    [Address(RVA = "0xC59CF0", Offset = "0xC58AF0", VA = "0x10C59CF0")]
    public JSON_QuestCountFormatter()
    {
    }

    [Token(Token = "0x6001ED3")]
    [Address(RVA = "0xC59BF0", Offset = "0xC589F0", VA = "0x10C59BF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestCount value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ED4")]
    [Address(RVA = "0xC59910", Offset = "0xC58710", VA = "0x10C59910", Slot = "5")]
    public JSON_QuestCount Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestCount) null;
    }
  }
}
