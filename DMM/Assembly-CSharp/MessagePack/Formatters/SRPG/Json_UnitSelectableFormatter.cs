// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_UnitSelectableFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005B2")]
  public sealed class Json_UnitSelectableFormatter : 
    IMessagePackFormatter<Json_UnitSelectable>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FFC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FFD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A64")]
    [Address(RVA = "0x7A3B30", Offset = "0x7A2930", VA = "0x107A3B30")]
    public Json_UnitSelectableFormatter()
    {
    }

    [Token(Token = "0x6001A65")]
    [Address(RVA = "0x7A3990", Offset = "0x7A2790", VA = "0x107A3990", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_UnitSelectable value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A66")]
    [Address(RVA = "0x7A3660", Offset = "0x7A2460", VA = "0x107A3660", Slot = "5")]
    public Json_UnitSelectable Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_UnitSelectable) null;
    }
  }
}
