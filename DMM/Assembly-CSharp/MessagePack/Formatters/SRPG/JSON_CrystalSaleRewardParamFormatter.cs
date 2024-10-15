// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalSaleRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006D3")]
  public sealed class JSON_CrystalSaleRewardParamFormatter : 
    IMessagePackFormatter<JSON_CrystalSaleRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400123E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400123F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DC7")]
    [Address(RVA = "0xC11BD0", Offset = "0xC109D0", VA = "0x10C11BD0")]
    public JSON_CrystalSaleRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001DC8")]
    [Address(RVA = "0xC11A70", Offset = "0xC10870", VA = "0x10C11A70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalSaleRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DC9")]
    [Address(RVA = "0xC11720", Offset = "0xC10520", VA = "0x10C11720", Slot = "5")]
    public JSON_CrystalSaleRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalSaleRewardParam) null;
    }
  }
}
