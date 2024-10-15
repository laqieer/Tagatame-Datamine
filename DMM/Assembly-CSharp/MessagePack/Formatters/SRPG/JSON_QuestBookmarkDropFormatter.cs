// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestBookmarkDropFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200084F")]
  public sealed class JSON_QuestBookmarkDropFormatter : 
    IMessagePackFormatter<JSON_QuestBookmarkDrop>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400152E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400152F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600223B")]
    [Address(RVA = "0xD8ED10", Offset = "0xD8DB10", VA = "0x10D8ED10")]
    public JSON_QuestBookmarkDropFormatter()
    {
    }

    [Token(Token = "0x600223C")]
    [Address(RVA = "0xD8EB70", Offset = "0xD8D970", VA = "0x10D8EB70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestBookmarkDrop value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600223D")]
    [Address(RVA = "0xD8E860", Offset = "0xD8D660", VA = "0x10D8E860", Slot = "5")]
    public JSON_QuestBookmarkDrop Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestBookmarkDrop) null;
    }
  }
}
