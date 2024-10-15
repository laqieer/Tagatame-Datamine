// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AIParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005E6")]
  public sealed class JSON_AIParamFormatter : 
    IMessagePackFormatter<JSON_AIParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001064")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001065")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B00")]
    [Address(RVA = "0xB8FD30", Offset = "0xB8EB30", VA = "0x10B8FD30")]
    public JSON_AIParamFormatter()
    {
    }

    [Token(Token = "0x6001B01")]
    [Address(RVA = "0xB8F590", Offset = "0xB8E390", VA = "0x10B8F590", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AIParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B02")]
    [Address(RVA = "0xB8EC20", Offset = "0xB8DA20", VA = "0x10B8EC20", Slot = "5")]
    public JSON_AIParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AIParam) null;
    }
  }
}
