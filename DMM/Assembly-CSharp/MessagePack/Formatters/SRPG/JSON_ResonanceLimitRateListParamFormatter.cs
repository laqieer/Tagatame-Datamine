// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResonanceLimitRateListParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006C8")]
  public sealed class JSON_ResonanceLimitRateListParamFormatter : 
    IMessagePackFormatter<JSON_ResonanceLimitRateListParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001228")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001229")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DA6")]
    [Address(RVA = "0xC18B60", Offset = "0xC17960", VA = "0x10C18B60")]
    public JSON_ResonanceLimitRateListParamFormatter()
    {
    }

    [Token(Token = "0x6001DA7")]
    [Address(RVA = "0xC18A00", Offset = "0xC17800", VA = "0x10C18A00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResonanceLimitRateListParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DA8")]
    [Address(RVA = "0xC186B0", Offset = "0xC174B0", VA = "0x10C186B0", Slot = "5")]
    public JSON_ResonanceLimitRateListParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResonanceLimitRateListParam) null;
    }
  }
}
