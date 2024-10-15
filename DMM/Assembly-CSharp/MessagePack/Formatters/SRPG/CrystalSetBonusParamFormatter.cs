// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CrystalSetBonusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B0D")]
  public sealed class CrystalSetBonusParamFormatter : 
    IMessagePackFormatter<CrystalSetBonusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AAA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AAB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A75")]
    [Address(RVA = "0xF31D60", Offset = "0xF30B60", VA = "0x10F31D60")]
    public CrystalSetBonusParamFormatter()
    {
    }

    [Token(Token = "0x6002A76")]
    [Address(RVA = "0xF31A30", Offset = "0xF30830", VA = "0x10F31A30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CrystalSetBonusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A77")]
    [Address(RVA = "0xF31710", Offset = "0xF30510", VA = "0x10F31710", Slot = "5")]
    public CrystalSetBonusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CrystalSetBonusParam) null;
    }
  }
}
