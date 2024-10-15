// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondMaterialDatasFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009C6")]
  public sealed class BondMaterialDatasFormatter : 
    IMessagePackFormatter<BondMaterialDatas>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400181C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400181D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026A0")]
    [Address(RVA = "0xE66550", Offset = "0xE65350", VA = "0x10E66550")]
    public BondMaterialDatasFormatter()
    {
    }

    [Token(Token = "0x60026A1")]
    [Address(RVA = "0xE66420", Offset = "0xE65220", VA = "0x10E66420", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondMaterialDatas value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026A2")]
    [Address(RVA = "0xE66140", Offset = "0xE64F40", VA = "0x10E66140", Slot = "5")]
    public BondMaterialDatas Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondMaterialDatas) null;
    }
  }
}
