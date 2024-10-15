// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidDamageAmountRewardAmountParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000628")]
  public sealed class JSON_RaidDamageAmountRewardAmountParamFormatter : 
    IMessagePackFormatter<JSON_RaidDamageAmountRewardAmountParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010E8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010E9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BC6")]
    [Address(RVA = "0xBC29F0", Offset = "0xBC17F0", VA = "0x10BC29F0")]
    public JSON_RaidDamageAmountRewardAmountParamFormatter()
    {
    }

    [Token(Token = "0x6001BC7")]
    [Address(RVA = "0xBC28C0", Offset = "0xBC16C0", VA = "0x10BC28C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidDamageAmountRewardAmountParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BC8")]
    [Address(RVA = "0xBC25B0", Offset = "0xBC13B0", VA = "0x10BC25B0", Slot = "5")]
    public JSON_RaidDamageAmountRewardAmountParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidDamageAmountRewardAmountParam) null;
    }
  }
}
