// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondRecipeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006B9")]
  public sealed class Json_BondRecipeParamFormatter : 
    IMessagePackFormatter<Json_BondRecipeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400120A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400120B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D79")]
    [Address(RVA = "0xC21DF0", Offset = "0xC20BF0", VA = "0x10C21DF0")]
    public Json_BondRecipeParamFormatter()
    {
    }

    [Token(Token = "0x6001D7A")]
    [Address(RVA = "0xC21C10", Offset = "0xC20A10", VA = "0x10C21C10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondRecipeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D7B")]
    [Address(RVA = "0xC218D0", Offset = "0xC206D0", VA = "0x10C218D0", Slot = "5")]
    public Json_BondRecipeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondRecipeParam) null;
    }
  }
}
