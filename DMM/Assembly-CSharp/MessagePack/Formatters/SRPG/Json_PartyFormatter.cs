// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_PartyFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200089B")]
  public sealed class Json_PartyFormatter : IMessagePackFormatter<Json_Party>, IMessagePackFormatter
  {
    [Token(Token = "0x40015C6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015C7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600231F")]
    [Address(RVA = "0xDBCF80", Offset = "0xDBBD80", VA = "0x10DBCF80")]
    public Json_PartyFormatter()
    {
    }

    [Token(Token = "0x6002320")]
    [Address(RVA = "0xDBCD30", Offset = "0xDBBB30", VA = "0x10DBCD30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Party value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002321")]
    [Address(RVA = "0xDBC990", Offset = "0xDBB790", VA = "0x10DBC990", Slot = "5")]
    public Json_Party Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Party) null;
    }
  }
}
