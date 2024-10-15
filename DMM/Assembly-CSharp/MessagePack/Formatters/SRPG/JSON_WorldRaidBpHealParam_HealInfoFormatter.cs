// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidBpHealParam_HealInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A85")]
  public sealed class JSON_WorldRaidBpHealParam_HealInfoFormatter : 
    IMessagePackFormatter<JSON_WorldRaidBpHealParam.HealInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400199A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400199B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028DD")]
    [Address(RVA = "0xEE9F30", Offset = "0xEE8D30", VA = "0x10EE9F30")]
    public JSON_WorldRaidBpHealParam_HealInfoFormatter()
    {
    }

    [Token(Token = "0x60028DE")]
    [Address(RVA = "0xEE9E00", Offset = "0xEE8C00", VA = "0x10EE9E00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidBpHealParam.HealInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028DF")]
    [Address(RVA = "0xEE9AE0", Offset = "0xEE88E0", VA = "0x10EE9AE0", Slot = "5")]
    public JSON_WorldRaidBpHealParam.HealInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidBpHealParam.HealInfo) null;
    }
  }
}
