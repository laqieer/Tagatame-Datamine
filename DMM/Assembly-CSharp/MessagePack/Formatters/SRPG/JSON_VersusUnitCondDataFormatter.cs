// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusUnitCondDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A8F")]
  public sealed class JSON_VersusUnitCondDataFormatter : 
    IMessagePackFormatter<JSON_VersusUnitCondData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019AE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019AF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028FB")]
    [Address(RVA = "0xEE7E90", Offset = "0xEE6C90", VA = "0x10EE7E90")]
    public JSON_VersusUnitCondDataFormatter()
    {
    }

    [Token(Token = "0x60028FC")]
    [Address(RVA = "0xEE7C10", Offset = "0xEE6A10", VA = "0x10EE7C10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusUnitCondData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028FD")]
    [Address(RVA = "0xEE77E0", Offset = "0xEE65E0", VA = "0x10EE77E0", Slot = "5")]
    public JSON_VersusUnitCondData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusUnitCondData) null;
    }
  }
}
