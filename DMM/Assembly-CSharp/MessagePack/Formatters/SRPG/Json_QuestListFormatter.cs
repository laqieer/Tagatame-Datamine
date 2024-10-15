// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_QuestListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A98")]
  public sealed class Json_QuestListFormatter : 
    IMessagePackFormatter<Json_QuestList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019C0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019C1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002916")]
    [Address(RVA = "0xEF8900", Offset = "0xEF7700", VA = "0x10EF8900")]
    public Json_QuestListFormatter()
    {
    }

    [Token(Token = "0x6002917")]
    [Address(RVA = "0xEF3060", Offset = "0xEF1E60", VA = "0x10EF3060", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_QuestList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002918")]
    [Address(RVA = "0xEF00E0", Offset = "0xEEEEE0", VA = "0x10EF00E0", Slot = "5")]
    public Json_QuestList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_QuestList) null;
    }
  }
}
