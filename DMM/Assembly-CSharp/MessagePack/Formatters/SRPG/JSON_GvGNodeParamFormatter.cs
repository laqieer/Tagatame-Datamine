// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGNodeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008E1")]
  public sealed class JSON_GvGNodeParamFormatter : 
    IMessagePackFormatter<JSON_GvGNodeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001652")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001653")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023F1")]
    [Address(RVA = "0xDD2E20", Offset = "0xDD1C20", VA = "0x10DD2E20")]
    public JSON_GvGNodeParamFormatter()
    {
    }

    [Token(Token = "0x60023F2")]
    [Address(RVA = "0xDD29C0", Offset = "0xDD17C0", VA = "0x10DD29C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGNodeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023F3")]
    [Address(RVA = "0xDD2380", Offset = "0xDD1180", VA = "0x10DD2380", Slot = "5")]
    public JSON_GvGNodeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGNodeParam) null;
    }
  }
}
