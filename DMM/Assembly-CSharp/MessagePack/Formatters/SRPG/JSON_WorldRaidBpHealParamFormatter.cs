// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidBpHealParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A86")]
  public sealed class JSON_WorldRaidBpHealParamFormatter : 
    IMessagePackFormatter<JSON_WorldRaidBpHealParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400199C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400199D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028E0")]
    [Address(RVA = "0xEE9960", Offset = "0xEE8760", VA = "0x10EE9960")]
    public JSON_WorldRaidBpHealParamFormatter()
    {
    }

    [Token(Token = "0x60028E1")]
    [Address(RVA = "0xEE9780", Offset = "0xEE8580", VA = "0x10EE9780", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidBpHealParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028E2")]
    [Address(RVA = "0xEE9440", Offset = "0xEE8240", VA = "0x10EE9440", Slot = "5")]
    public JSON_WorldRaidBpHealParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidBpHealParam) null;
    }
  }
}
