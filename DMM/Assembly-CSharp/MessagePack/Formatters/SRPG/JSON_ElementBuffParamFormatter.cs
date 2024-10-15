// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ElementBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006CD")]
  public sealed class JSON_ElementBuffParamFormatter : 
    IMessagePackFormatter<JSON_ElementBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001232")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001233")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DB5")]
    [Address(RVA = "0xC15830", Offset = "0xC14630", VA = "0x10C15830")]
    public JSON_ElementBuffParamFormatter()
    {
    }

    [Token(Token = "0x6001DB6")]
    [Address(RVA = "0xC15630", Offset = "0xC14430", VA = "0x10C15630", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ElementBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DB7")]
    [Address(RVA = "0xC15260", Offset = "0xC14060", VA = "0x10C15260", Slot = "5")]
    public JSON_ElementBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ElementBuffParam) null;
    }
  }
}
