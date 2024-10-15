// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TruthEquipmentRecipeMaterialParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006AA")]
  public sealed class JSON_TruthEquipmentRecipeMaterialParamFormatter : 
    IMessagePackFormatter<JSON_TruthEquipmentRecipeMaterialParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011EC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011ED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D4C")]
    [Address(RVA = "0xC0A600", Offset = "0xC09400", VA = "0x10C0A600")]
    public JSON_TruthEquipmentRecipeMaterialParamFormatter()
    {
    }

    [Token(Token = "0x6001D4D")]
    [Address(RVA = "0xC0A4D0", Offset = "0xC092D0", VA = "0x10C0A4D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TruthEquipmentRecipeMaterialParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D4E")]
    [Address(RVA = "0xC0A1C0", Offset = "0xC08FC0", VA = "0x10C0A1C0", Slot = "5")]
    public JSON_TruthEquipmentRecipeMaterialParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TruthEquipmentRecipeMaterialParam) null;
    }
  }
}
