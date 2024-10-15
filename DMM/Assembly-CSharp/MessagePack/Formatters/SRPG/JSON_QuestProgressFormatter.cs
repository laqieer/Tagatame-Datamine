// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestProgressFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200072D")]
  public sealed class JSON_QuestProgressFormatter : 
    IMessagePackFormatter<JSON_QuestProgress>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012F2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012F3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001ED5")]
    [Address(RVA = "0xC5A6F0", Offset = "0xC594F0", VA = "0x10C5A6F0")]
    public JSON_QuestProgressFormatter()
    {
    }

    [Token(Token = "0x6001ED6")]
    [Address(RVA = "0xC5A380", Offset = "0xC59180", VA = "0x10C5A380", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestProgress value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ED7")]
    [Address(RVA = "0xC59E70", Offset = "0xC58C70", VA = "0x10C59E70", Slot = "5")]
    public JSON_QuestProgress Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestProgress) null;
    }
  }
}
