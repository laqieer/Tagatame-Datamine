// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitRentalNotificationDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000659")]
  public sealed class JSON_UnitRentalNotificationDataParamFormatter : 
    IMessagePackFormatter<JSON_UnitRentalNotificationDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400114A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400114B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C59")]
    [Address(RVA = "0xBF33E0", Offset = "0xBF21E0", VA = "0x10BF33E0")]
    public JSON_UnitRentalNotificationDataParamFormatter()
    {
    }

    [Token(Token = "0x6001C5A")]
    [Address(RVA = "0xBF3280", Offset = "0xBF2080", VA = "0x10BF3280", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitRentalNotificationDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C5B")]
    [Address(RVA = "0xBF2F40", Offset = "0xBF1D40", VA = "0x10BF2F40", Slot = "5")]
    public JSON_UnitRentalNotificationDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitRentalNotificationDataParam) null;
    }
  }
}
