// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuerrillaShopScheduleAdventParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008EE")]
  public sealed class JSON_GuerrillaShopScheduleAdventParamFormatter : 
    IMessagePackFormatter<JSON_GuerrillaShopScheduleAdventParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400166C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400166D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002418")]
    [Address(RVA = "0xDE2A50", Offset = "0xDE1850", VA = "0x10DE2A50")]
    public JSON_GuerrillaShopScheduleAdventParamFormatter()
    {
    }

    [Token(Token = "0x6002419")]
    [Address(RVA = "0xDE2950", Offset = "0xDE1750", VA = "0x10DE2950", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuerrillaShopScheduleAdventParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600241A")]
    [Address(RVA = "0xDE2670", Offset = "0xDE1470", VA = "0x10DE2670", Slot = "5")]
    public JSON_GuerrillaShopScheduleAdventParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuerrillaShopScheduleAdventParam) null;
    }
  }
}
