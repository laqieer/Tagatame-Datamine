// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidBossParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A84")]
  public sealed class JSON_WorldRaidBossParamFormatter : 
    IMessagePackFormatter<JSON_WorldRaidBossParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001998")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001999")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028DA")]
    [Address(RVA = "0xEE90A0", Offset = "0xEE7EA0", VA = "0x10EE90A0")]
    public JSON_WorldRaidBossParamFormatter()
    {
    }

    [Token(Token = "0x60028DB")]
    [Address(RVA = "0xEE8DA0", Offset = "0xEE7BA0", VA = "0x10EE8DA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidBossParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028DC")]
    [Address(RVA = "0xEE88F0", Offset = "0xEE76F0", VA = "0x10EE88F0", Slot = "5")]
    public JSON_WorldRaidBossParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidBossParam) null;
    }
  }
}
