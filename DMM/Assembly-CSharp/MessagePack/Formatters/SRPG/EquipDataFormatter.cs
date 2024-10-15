// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EquipDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000775")]
  public sealed class EquipDataFormatter : IMessagePackFormatter<EquipData>, IMessagePackFormatter
  {
    [Token(Token = "0x4001382")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001383")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FAD")]
    [Address(RVA = "0xCAF0C0", Offset = "0xCADEC0", VA = "0x10CAF0C0")]
    public EquipDataFormatter()
    {
    }

    [Token(Token = "0x6001FAE")]
    [Address(RVA = "0xCAEBA0", Offset = "0xCAD9A0", VA = "0x10CAEBA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EquipData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FAF")]
    [Address(RVA = "0xCAE750", Offset = "0xCAD550", VA = "0x10CAE750", Slot = "5")]
    public EquipData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EquipData) null;
    }
  }
}
