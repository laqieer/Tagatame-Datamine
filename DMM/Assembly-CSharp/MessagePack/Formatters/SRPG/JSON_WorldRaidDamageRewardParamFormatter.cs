// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidDamageRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008C4")]
  public sealed class JSON_WorldRaidDamageRewardParamFormatter : 
    IMessagePackFormatter<JSON_WorldRaidDamageRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001618")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001619")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600239A")]
    [Address(RVA = "0xDD5040", Offset = "0xDD3E40", VA = "0x10DD5040")]
    public JSON_WorldRaidDamageRewardParamFormatter()
    {
    }

    [Token(Token = "0x600239B")]
    [Address(RVA = "0xDD4E60", Offset = "0xDD3C60", VA = "0x10DD4E60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidDamageRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600239C")]
    [Address(RVA = "0xDD4B20", Offset = "0xDD3920", VA = "0x10DD4B20", Slot = "5")]
    public JSON_WorldRaidDamageRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidDamageRewardParam) null;
    }
  }
}
