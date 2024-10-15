// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.QuestBookmarkDropFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000851")]
  public sealed class QuestBookmarkDropFormatter : 
    IMessagePackFormatter<QuestBookmarkDrop>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001532")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001533")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002241")]
    [Address(RVA = "0xD96D90", Offset = "0xD95B90", VA = "0x10D96D90")]
    public QuestBookmarkDropFormatter()
    {
    }

    [Token(Token = "0x6002242")]
    [Address(RVA = "0xD96BF0", Offset = "0xD959F0", VA = "0x10D96BF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      QuestBookmarkDrop value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002243")]
    [Address(RVA = "0xD96910", Offset = "0xD95710", VA = "0x10D96910", Slot = "5")]
    public QuestBookmarkDrop Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (QuestBookmarkDrop) null;
    }
  }
}
