// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitRentalParam_QuestInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200065B")]
  public sealed class JSON_UnitRentalParam_QuestInfoFormatter : 
    IMessagePackFormatter<JSON_UnitRentalParam.QuestInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400114E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400114F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C5F")]
    [Address(RVA = "0xBF5230", Offset = "0xBF4030", VA = "0x10BF5230")]
    public JSON_UnitRentalParam_QuestInfoFormatter()
    {
    }

    [Token(Token = "0x6001C60")]
    [Address(RVA = "0xBF5100", Offset = "0xBF3F00", VA = "0x10BF5100", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitRentalParam.QuestInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C61")]
    [Address(RVA = "0xBF4DF0", Offset = "0xBF3BF0", VA = "0x10BF4DF0", Slot = "5")]
    public JSON_UnitRentalParam.QuestInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitRentalParam.QuestInfo) null;
    }
  }
}
