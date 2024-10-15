// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BondLvUpMaterialsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009C5")]
  public sealed class JSON_BondLvUpMaterialsFormatter : 
    IMessagePackFormatter<JSON_BondLvUpMaterials>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400181A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400181B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600269D")]
    [Address(RVA = "0xE6D870", Offset = "0xE6C670", VA = "0x10E6D870")]
    public JSON_BondLvUpMaterialsFormatter()
    {
    }

    [Token(Token = "0x600269E")]
    [Address(RVA = "0xE6D690", Offset = "0xE6C490", VA = "0x10E6D690", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BondLvUpMaterials value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600269F")]
    [Address(RVA = "0xE6D350", Offset = "0xE6C150", VA = "0x10E6D350", Slot = "5")]
    public JSON_BondLvUpMaterials Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BondLvUpMaterials) null;
    }
  }
}
