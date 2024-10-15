// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000959")]
  public sealed class JSON_WorldRaidRewardParamFormatter : 
    IMessagePackFormatter<JSON_WorldRaidRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001742")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001743")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002559")]
    [Address(RVA = "0xE169E0", Offset = "0xE157E0", VA = "0x10E169E0")]
    public JSON_WorldRaidRewardParamFormatter()
    {
    }

    [Token(Token = "0x600255A")]
    [Address(RVA = "0xE16800", Offset = "0xE15600", VA = "0x10E16800", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600255B")]
    [Address(RVA = "0xE164C0", Offset = "0xE152C0", VA = "0x10E164C0", Slot = "5")]
    public JSON_WorldRaidRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidRewardParam) null;
    }
  }
}
