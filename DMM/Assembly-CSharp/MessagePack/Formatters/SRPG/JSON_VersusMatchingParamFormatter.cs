// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusMatchingParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005FD")]
  public sealed class JSON_VersusMatchingParamFormatter : 
    IMessagePackFormatter<JSON_VersusMatchingParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001092")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001093")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B45")]
    [Address(RVA = "0xBB23F0", Offset = "0xBB11F0", VA = "0x10BB23F0")]
    public JSON_VersusMatchingParamFormatter()
    {
    }

    [Token(Token = "0x6001B46")]
    [Address(RVA = "0xBB22C0", Offset = "0xBB10C0", VA = "0x10BB22C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusMatchingParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B47")]
    [Address(RVA = "0xBB1FB0", Offset = "0xBB0DB0", VA = "0x10BB1FB0", Slot = "5")]
    public JSON_VersusMatchingParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusMatchingParam) null;
    }
  }
}
