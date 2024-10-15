// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePridePotentialSlotDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005BB")]
  public sealed class JSON_RunePridePotentialSlotDataFormatter : 
    IMessagePackFormatter<JSON_RunePridePotentialSlotData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400100E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400100F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A7F")]
    [Address(RVA = "0x791F90", Offset = "0x790D90", VA = "0x10791F90")]
    public JSON_RunePridePotentialSlotDataFormatter()
    {
    }

    [Token(Token = "0x6001A80")]
    [Address(RVA = "0x791D60", Offset = "0x790B60", VA = "0x10791D60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePridePotentialSlotData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A81")]
    [Address(RVA = "0x791950", Offset = "0x790750", VA = "0x10791950", Slot = "5")]
    public JSON_RunePridePotentialSlotData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePridePotentialSlotData) null;
    }
  }
}
