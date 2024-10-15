// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuerrillaShopAdventQuestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A2A")]
  public sealed class JSON_GuerrillaShopAdventQuestParamFormatter : 
    IMessagePackFormatter<JSON_GuerrillaShopAdventQuestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018E4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018E5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027CC")]
    [Address(RVA = "0xEA1360", Offset = "0xEA0160", VA = "0x10EA1360")]
    public JSON_GuerrillaShopAdventQuestParamFormatter()
    {
    }

    [Token(Token = "0x60027CD")]
    [Address(RVA = "0xEA1230", Offset = "0xEA0030", VA = "0x10EA1230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuerrillaShopAdventQuestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027CE")]
    [Address(RVA = "0xEA0F20", Offset = "0xE9FD20", VA = "0x10EA0F20", Slot = "5")]
    public JSON_GuerrillaShopAdventQuestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuerrillaShopAdventQuestParam) null;
    }
  }
}
