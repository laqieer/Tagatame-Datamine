// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitRentalNotificationParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200065A")]
  public sealed class JSON_UnitRentalNotificationParamFormatter : 
    IMessagePackFormatter<JSON_UnitRentalNotificationParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400114C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400114D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C5C")]
    [Address(RVA = "0xBF3A80", Offset = "0xBF2880", VA = "0x10BF3A80")]
    public JSON_UnitRentalNotificationParamFormatter()
    {
    }

    [Token(Token = "0x6001C5D")]
    [Address(RVA = "0xBF38A0", Offset = "0xBF26A0", VA = "0x10BF38A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitRentalNotificationParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C5E")]
    [Address(RVA = "0xBF3560", Offset = "0xBF2360", VA = "0x10BF3560", Slot = "5")]
    public JSON_UnitRentalNotificationParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitRentalNotificationParam) null;
    }
  }
}
