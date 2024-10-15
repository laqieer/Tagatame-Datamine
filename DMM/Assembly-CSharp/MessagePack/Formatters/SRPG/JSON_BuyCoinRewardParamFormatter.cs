// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BuyCoinRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200063F")]
  public sealed class JSON_BuyCoinRewardParamFormatter : 
    IMessagePackFormatter<JSON_BuyCoinRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001116")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001117")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C0B")]
    [Address(RVA = "0xBCD7B0", Offset = "0xBCC5B0", VA = "0x10BCD7B0")]
    public JSON_BuyCoinRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001C0C")]
    [Address(RVA = "0xBCD4E0", Offset = "0xBCC2E0", VA = "0x10BCD4E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BuyCoinRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C0D")]
    [Address(RVA = "0xBCD0C0", Offset = "0xBCBEC0", VA = "0x10BCD0C0", Slot = "5")]
    public JSON_BuyCoinRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BuyCoinRewardParam) null;
    }
  }
}
