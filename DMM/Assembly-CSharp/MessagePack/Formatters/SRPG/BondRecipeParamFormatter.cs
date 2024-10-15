// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondRecipeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200096A")]
  public sealed class BondRecipeParamFormatter : 
    IMessagePackFormatter<BondRecipeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001764")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001765")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600258C")]
    [Address(RVA = "0xE25670", Offset = "0xE24470", VA = "0x10E25670")]
    public BondRecipeParamFormatter()
    {
    }

    [Token(Token = "0x600258D")]
    [Address(RVA = "0xE25490", Offset = "0xE24290", VA = "0x10E25490", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondRecipeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600258E")]
    [Address(RVA = "0xE25180", Offset = "0xE23F80", VA = "0x10E25180", Slot = "5")]
    public BondRecipeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondRecipeParam) null;
    }
  }
}
