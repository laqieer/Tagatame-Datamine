// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_RuneEnforceGaugeDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200085C")]
  public sealed class Json_RuneEnforceGaugeDataFormatter : 
    IMessagePackFormatter<Json_RuneEnforceGaugeData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001548")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001549")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002262")]
    [Address(RVA = "0xD96790", Offset = "0xD95590", VA = "0x10D96790")]
    public Json_RuneEnforceGaugeDataFormatter()
    {
    }

    [Token(Token = "0x6002263")]
    [Address(RVA = "0xD96690", Offset = "0xD95490", VA = "0x10D96690", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_RuneEnforceGaugeData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002264")]
    [Address(RVA = "0xD963B0", Offset = "0xD951B0", VA = "0x10D963B0", Slot = "5")]
    public Json_RuneEnforceGaugeData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_RuneEnforceGaugeData) null;
    }
  }
}
