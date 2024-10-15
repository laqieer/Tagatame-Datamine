// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusMatchCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005FE")]
  public sealed class JSON_VersusMatchCondParamFormatter : 
    IMessagePackFormatter<JSON_VersusMatchCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001094")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001095")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B48")]
    [Address(RVA = "0xBB1DB0", Offset = "0xBB0BB0", VA = "0x10BB1DB0")]
    public JSON_VersusMatchCondParamFormatter()
    {
    }

    [Token(Token = "0x6001B49")]
    [Address(RVA = "0xBB1C80", Offset = "0xBB0A80", VA = "0x10BB1C80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusMatchCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B4A")]
    [Address(RVA = "0xBB1960", Offset = "0xBB0760", VA = "0x10BB1960", Slot = "5")]
    public JSON_VersusMatchCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusMatchCondParam) null;
    }
  }
}
