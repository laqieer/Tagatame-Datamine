// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BreakObjParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005FC")]
  public sealed class JSON_BreakObjParamFormatter : 
    IMessagePackFormatter<JSON_BreakObjParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001090")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001091")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B42")]
    [Address(RVA = "0xBA5A20", Offset = "0xBA4820", VA = "0x10BA5A20")]
    public JSON_BreakObjParamFormatter()
    {
    }

    [Token(Token = "0x6001B43")]
    [Address(RVA = "0xBA5640", Offset = "0xBA4440", VA = "0x10BA5640", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BreakObjParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B44")]
    [Address(RVA = "0xBA5090", Offset = "0xBA3E90", VA = "0x10BA5090", Slot = "5")]
    public JSON_BreakObjParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BreakObjParam) null;
    }
  }
}
