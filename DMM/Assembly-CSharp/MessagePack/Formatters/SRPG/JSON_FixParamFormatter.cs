// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FixParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005D6")]
  public sealed class JSON_FixParamFormatter : 
    IMessagePackFormatter<JSON_FixParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001044")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001045")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AD0")]
    [Address(RVA = "0x874B40", Offset = "0x873940", VA = "0x10874B40")]
    public JSON_FixParamFormatter()
    {
    }

    [Token(Token = "0x6001AD1")]
    [Address(RVA = "0x86FA80", Offset = "0x86E880", VA = "0x1086FA80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FixParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AD2")]
    [Address(RVA = "0x86A300", Offset = "0x869100", VA = "0x1086A300", Slot = "5")]
    public JSON_FixParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FixParam) null;
    }
  }
}
