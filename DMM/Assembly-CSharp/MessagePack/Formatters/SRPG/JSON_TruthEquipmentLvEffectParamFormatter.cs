// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TruthEquipmentLvEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006A8")]
  public sealed class JSON_TruthEquipmentLvEffectParamFormatter : 
    IMessagePackFormatter<JSON_TruthEquipmentLvEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011E8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011E9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D46")]
    [Address(RVA = "0xC09610", Offset = "0xC08410", VA = "0x10C09610")]
    public JSON_TruthEquipmentLvEffectParamFormatter()
    {
    }

    [Token(Token = "0x6001D47")]
    [Address(RVA = "0xC09460", Offset = "0xC08260", VA = "0x10C09460", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TruthEquipmentLvEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D48")]
    [Address(RVA = "0xC090D0", Offset = "0xC07ED0", VA = "0x10C090D0", Slot = "5")]
    public JSON_TruthEquipmentLvEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TruthEquipmentLvEffectParam) null;
    }
  }
}
