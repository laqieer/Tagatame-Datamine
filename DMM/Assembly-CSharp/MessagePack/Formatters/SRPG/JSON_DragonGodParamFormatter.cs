// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DragonGodParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A91")]
  public sealed class JSON_DragonGodParamFormatter : 
    IMessagePackFormatter<JSON_DragonGodParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019B2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019B3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002901")]
    [Address(RVA = "0xEDAA00", Offset = "0xED9800", VA = "0x10EDAA00")]
    public JSON_DragonGodParamFormatter()
    {
    }

    [Token(Token = "0x6002902")]
    [Address(RVA = "0xEDA7C0", Offset = "0xED95C0", VA = "0x10EDA7C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DragonGodParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002903")]
    [Address(RVA = "0xEDA3C0", Offset = "0xED91C0", VA = "0x10EDA3C0", Slot = "5")]
    public JSON_DragonGodParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DragonGodParam) null;
    }
  }
}
