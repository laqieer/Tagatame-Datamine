// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BondMaterialDatasFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009C3")]
  public sealed class JSON_BondMaterialDatasFormatter : 
    IMessagePackFormatter<JSON_BondMaterialDatas>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001816")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001817")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002697")]
    [Address(RVA = "0xE6DEA0", Offset = "0xE6CCA0", VA = "0x10E6DEA0")]
    public JSON_BondMaterialDatasFormatter()
    {
    }

    [Token(Token = "0x6002698")]
    [Address(RVA = "0xE6DD40", Offset = "0xE6CB40", VA = "0x10E6DD40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BondMaterialDatas value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002699")]
    [Address(RVA = "0xE6D9F0", Offset = "0xE6C7F0", VA = "0x10E6D9F0", Slot = "5")]
    public JSON_BondMaterialDatas Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BondMaterialDatas) null;
    }
  }
}
