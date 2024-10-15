// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidPeriodParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000855")]
  public sealed class JSON_GuildRaidPeriodParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidPeriodParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400153A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400153B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600224D")]
    [Address(RVA = "0xD88CA0", Offset = "0xD87AA0", VA = "0x10D88CA0")]
    public JSON_GuildRaidPeriodParamFormatter()
    {
    }

    [Token(Token = "0x600224E")]
    [Address(RVA = "0xD885B0", Offset = "0xD873B0", VA = "0x10D885B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidPeriodParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600224F")]
    [Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x10D87DD0", Slot = "5")]
    public JSON_GuildRaidPeriodParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidPeriodParam) null;
    }
  }
}
