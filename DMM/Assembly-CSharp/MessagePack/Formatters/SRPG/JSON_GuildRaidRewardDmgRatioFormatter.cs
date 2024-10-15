// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRewardDmgRatioFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A7D")]
  public sealed class JSON_GuildRaidRewardDmgRatioFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRewardDmgRatio>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400198A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400198B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028C5")]
    [Address(RVA = "0xEDC410", Offset = "0xEDB210", VA = "0x10EDC410")]
    public JSON_GuildRaidRewardDmgRatioFormatter()
    {
    }

    [Token(Token = "0x60028C6")]
    [Address(RVA = "0xEDC2E0", Offset = "0xEDB0E0", VA = "0x10EDC2E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRewardDmgRatio value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028C7")]
    [Address(RVA = "0xEDBFD0", Offset = "0xEDADD0", VA = "0x10EDBFD0", Slot = "5")]
    public JSON_GuildRaidRewardDmgRatio Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRewardDmgRatio) null;
    }
  }
}
