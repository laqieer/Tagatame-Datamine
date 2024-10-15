// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_EquipFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005AC")]
  public sealed class Json_EquipFormatter : IMessagePackFormatter<Json_Equip>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FF0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FF1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A52")]
    [Address(RVA = "0x7998F0", Offset = "0x7986F0", VA = "0x107998F0")]
    public Json_EquipFormatter()
    {
    }

    [Token(Token = "0x6001A53")]
    [Address(RVA = "0x799780", Offset = "0x798580", VA = "0x10799780", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Equip value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A54")]
    [Address(RVA = "0x799410", Offset = "0x798210", VA = "0x10799410", Slot = "5")]
    public Json_Equip Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Equip) null;
    }
  }
}
