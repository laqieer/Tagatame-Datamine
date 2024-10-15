// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CustomTargetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200061B")]
  public sealed class JSON_CustomTargetParamFormatter : 
    IMessagePackFormatter<JSON_CustomTargetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010CE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010CF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B9F")]
    [Address(RVA = "0xBBBF70", Offset = "0xBBAD70", VA = "0x10BBBF70")]
    public JSON_CustomTargetParamFormatter()
    {
    }

    [Token(Token = "0x6001BA0")]
    [Address(RVA = "0xBBB920", Offset = "0xBBA720", VA = "0x10BBB920", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CustomTargetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BA1")]
    [Address(RVA = "0xBBB180", Offset = "0xBB9F80", VA = "0x10BBB180", Slot = "5")]
    public JSON_CustomTargetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CustomTargetParam) null;
    }
  }
}
