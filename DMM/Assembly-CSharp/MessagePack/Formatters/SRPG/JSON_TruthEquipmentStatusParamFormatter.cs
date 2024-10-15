// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TruthEquipmentStatusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006AD")]
  public sealed class JSON_TruthEquipmentStatusParamFormatter : 
    IMessagePackFormatter<JSON_TruthEquipmentStatusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011F2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011F3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D55")]
    [Address(RVA = "0xC0BA70", Offset = "0xC0A870", VA = "0x10C0BA70")]
    public JSON_TruthEquipmentStatusParamFormatter()
    {
    }

    [Token(Token = "0x6001D56")]
    [Address(RVA = "0xC0B890", Offset = "0xC0A690", VA = "0x10C0B890", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TruthEquipmentStatusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D57")]
    [Address(RVA = "0xC0B550", Offset = "0xC0A350", VA = "0x10C0B550", Slot = "5")]
    public JSON_TruthEquipmentStatusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TruthEquipmentStatusParam) null;
    }
  }
}
