// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidReportFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000738")]
  public sealed class JSON_GuildRaidReportFormatter : 
    IMessagePackFormatter<JSON_GuildRaidReport>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001308")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001309")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EF6")]
    [Address(RVA = "0xC85470", Offset = "0xC84270", VA = "0x10C85470")]
    public JSON_GuildRaidReportFormatter()
    {
    }

    [Token(Token = "0x6001EF7")]
    [Address(RVA = "0xC851E0", Offset = "0xC83FE0", VA = "0x10C851E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidReport value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EF8")]
    [Address(RVA = "0xC84DF0", Offset = "0xC83BF0", VA = "0x10C84DF0", Slot = "5")]
    public JSON_GuildRaidReport Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidReport) null;
    }
  }
}
