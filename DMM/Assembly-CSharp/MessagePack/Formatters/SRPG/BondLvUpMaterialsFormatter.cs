// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondLvUpMaterialsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009C9")]
  public sealed class BondLvUpMaterialsFormatter : 
    IMessagePackFormatter<BondLvUpMaterials>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001822")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001823")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026A9")]
    [Address(RVA = "0xE65FC0", Offset = "0xE64DC0", VA = "0x10E65FC0")]
    public BondLvUpMaterialsFormatter()
    {
    }

    [Token(Token = "0x60026AA")]
    [Address(RVA = "0xE65DE0", Offset = "0xE64BE0", VA = "0x10E65DE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondLvUpMaterials value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026AB")]
    [Address(RVA = "0xE65AA0", Offset = "0xE648A0", VA = "0x10E65AA0", Slot = "5")]
    public BondLvUpMaterials Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondLvUpMaterials) null;
    }
  }
}
