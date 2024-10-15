// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TruthEquipmentParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006A9")]
  public sealed class JSON_TruthEquipmentParamFormatter : 
    IMessagePackFormatter<JSON_TruthEquipmentParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011EA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D49")]
    [Address(RVA = "0xC09EF0", Offset = "0xC08CF0", VA = "0x10C09EF0")]
    public JSON_TruthEquipmentParamFormatter()
    {
    }

    [Token(Token = "0x6001D4A")]
    [Address(RVA = "0xC09C10", Offset = "0xC08A10", VA = "0x10C09C10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TruthEquipmentParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D4B")]
    [Address(RVA = "0xC09800", Offset = "0xC08600", VA = "0x10C09800", Slot = "5")]
    public JSON_TruthEquipmentParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TruthEquipmentParam) null;
    }
  }
}
