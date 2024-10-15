// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidLapRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A1A")]
  public sealed class JSON_WorldRaidLapRewardParamFormatter : 
    IMessagePackFormatter<JSON_WorldRaidLapRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018C4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018C5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600279C")]
    [Address(RVA = "0xEA46A0", Offset = "0xEA34A0", VA = "0x10EA46A0")]
    public JSON_WorldRaidLapRewardParamFormatter()
    {
    }

    [Token(Token = "0x600279D")]
    [Address(RVA = "0xEA44C0", Offset = "0xEA32C0", VA = "0x10EA44C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidLapRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600279E")]
    [Address(RVA = "0xEA4180", Offset = "0xEA2F80", VA = "0x10EA4180", Slot = "5")]
    public JSON_WorldRaidLapRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidLapRewardParam) null;
    }
  }
}
