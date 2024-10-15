// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidPeriodTimeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000854")]
  public sealed class JSON_GuildRaidPeriodTimeFormatter : 
    IMessagePackFormatter<JSON_GuildRaidPeriodTime>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001538")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001539")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600224A")]
    [Address(RVA = "0xD899C0", Offset = "0xD887C0", VA = "0x10D899C0")]
    public JSON_GuildRaidPeriodTimeFormatter()
    {
    }

    [Token(Token = "0x600224B")]
    [Address(RVA = "0xD89870", Offset = "0xD88670", VA = "0x10D89870", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidPeriodTime value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600224C")]
    [Address(RVA = "0xD89540", Offset = "0xD88340", VA = "0x10D89540", Slot = "5")]
    public JSON_GuildRaidPeriodTime Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidPeriodTime) null;
    }
  }
}
