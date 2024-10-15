// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BuyCoinRewardItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200063E")]
  public sealed class JSON_BuyCoinRewardItemParamFormatter : 
    IMessagePackFormatter<JSON_BuyCoinRewardItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001114")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001115")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C08")]
    [Address(RVA = "0xBCCED0", Offset = "0xBCBCD0", VA = "0x10BCCED0")]
    public JSON_BuyCoinRewardItemParamFormatter()
    {
    }

    [Token(Token = "0x6001C09")]
    [Address(RVA = "0xBCCD70", Offset = "0xBCBB70", VA = "0x10BCCD70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BuyCoinRewardItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C0A")]
    [Address(RVA = "0xBCCA20", Offset = "0xBCB820", VA = "0x10BCCA20", Slot = "5")]
    public JSON_BuyCoinRewardItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BuyCoinRewardItemParam) null;
    }
  }
}
