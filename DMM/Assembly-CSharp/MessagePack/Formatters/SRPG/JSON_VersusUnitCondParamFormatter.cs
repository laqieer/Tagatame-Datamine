// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusUnitCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A90")]
  public sealed class JSON_VersusUnitCondParamFormatter : 
    IMessagePackFormatter<JSON_VersusUnitCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019B0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019B1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028FE")]
    [Address(RVA = "0xEE8700", Offset = "0xEE7500", VA = "0x10EE8700")]
    public JSON_VersusUnitCondParamFormatter()
    {
    }

    [Token(Token = "0x60028FF")]
    [Address(RVA = "0xEE84E0", Offset = "0xEE72E0", VA = "0x10EE84E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusUnitCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002900")]
    [Address(RVA = "0xEE8160", Offset = "0xEE6F60", VA = "0x10EE8160", Slot = "5")]
    public JSON_VersusUnitCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusUnitCondParam) null;
    }
  }
}
