// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildTrainingUnitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000636")]
  public sealed class JSON_GuildTrainingUnitFormatter : 
    IMessagePackFormatter<JSON_GuildTrainingUnit>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001104")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001105")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BF0")]
    [Address(RVA = "0xBD7CE0", Offset = "0xBD6AE0", VA = "0x10BD7CE0")]
    public JSON_GuildTrainingUnitFormatter()
    {
    }

    [Token(Token = "0x6001BF1")]
    [Address(RVA = "0xBD7AA0", Offset = "0xBD68A0", VA = "0x10BD7AA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildTrainingUnit value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BF2")]
    [Address(RVA = "0xBD7700", Offset = "0xBD6500", VA = "0x10BD7700", Slot = "5")]
    public JSON_GuildTrainingUnit Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildTrainingUnit) null;
    }
  }
}
