// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondRecipeMatsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000969")]
  public sealed class BondRecipeMatsParamFormatter : 
    IMessagePackFormatter<BondRecipeMatsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001762")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001763")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002589")]
    [Address(RVA = "0xE25000", Offset = "0xE23E00", VA = "0x10E25000")]
    public BondRecipeMatsParamFormatter()
    {
    }

    [Token(Token = "0x600258A")]
    [Address(RVA = "0xE24EC0", Offset = "0xE23CC0", VA = "0x10E24EC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondRecipeMatsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600258B")]
    [Address(RVA = "0xE24BE0", Offset = "0xE239E0", VA = "0x10E24BE0", Slot = "5")]
    public BondRecipeMatsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondRecipeMatsParam) null;
    }
  }
}
