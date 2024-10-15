// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_GuerrillaShopPeriodFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000721")]
  public sealed class Json_GuerrillaShopPeriodFormatter : 
    IMessagePackFormatter<Json_GuerrillaShopPeriod>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012DA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012DB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EB1")]
    [Address(RVA = "0xC60180", Offset = "0xC5EF80", VA = "0x10C60180")]
    public Json_GuerrillaShopPeriodFormatter()
    {
    }

    [Token(Token = "0x6001EB2")]
    [Address(RVA = "0xC5FFE0", Offset = "0xC5EDE0", VA = "0x10C5FFE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_GuerrillaShopPeriod value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EB3")]
    [Address(RVA = "0xC5FC90", Offset = "0xC5EA90", VA = "0x10C5FC90", Slot = "5")]
    public Json_GuerrillaShopPeriod Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_GuerrillaShopPeriod) null;
    }
  }
}
