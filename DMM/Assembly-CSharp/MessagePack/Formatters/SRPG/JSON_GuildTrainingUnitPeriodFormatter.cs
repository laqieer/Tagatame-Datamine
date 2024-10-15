// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildTrainingUnitPeriodFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000635")]
  public sealed class JSON_GuildTrainingUnitPeriodFormatter : 
    IMessagePackFormatter<JSON_GuildTrainingUnitPeriod>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001102")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001103")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BED")]
    [Address(RVA = "0xBD8350", Offset = "0xBD7150", VA = "0x10BD8350")]
    public JSON_GuildTrainingUnitPeriodFormatter()
    {
    }

    [Token(Token = "0x6001BEE")]
    [Address(RVA = "0xBD8200", Offset = "0xBD7000", VA = "0x10BD8200", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildTrainingUnitPeriod value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BEF")]
    [Address(RVA = "0xBD7ED0", Offset = "0xBD6CD0", VA = "0x10BD7ED0", Slot = "5")]
    public JSON_GuildTrainingUnitPeriod Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildTrainingUnitPeriod) null;
    }
  }
}
