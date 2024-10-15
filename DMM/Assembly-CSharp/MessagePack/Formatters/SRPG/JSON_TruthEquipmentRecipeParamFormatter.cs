// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TruthEquipmentRecipeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006AB")]
  public sealed class JSON_TruthEquipmentRecipeParamFormatter : 
    IMessagePackFormatter<JSON_TruthEquipmentRecipeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011EE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011EF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D4F")]
    [Address(RVA = "0xC0AD20", Offset = "0xC09B20", VA = "0x10C0AD20")]
    public JSON_TruthEquipmentRecipeParamFormatter()
    {
    }

    [Token(Token = "0x6001D50")]
    [Address(RVA = "0xC0AB00", Offset = "0xC09900", VA = "0x10C0AB00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TruthEquipmentRecipeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D51")]
    [Address(RVA = "0xC0A780", Offset = "0xC09580", VA = "0x10C0A780", Slot = "5")]
    public JSON_TruthEquipmentRecipeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TruthEquipmentRecipeParam) null;
    }
  }
}
