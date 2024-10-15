// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_InitPlayerFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000704")]
  public sealed class JSON_InitPlayerFormatter : 
    IMessagePackFormatter<JSON_InitPlayer>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012A0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012A1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E5A")]
    [Address(RVA = "0xC27510", Offset = "0xC26310", VA = "0x10C27510")]
    public JSON_InitPlayerFormatter()
    {
    }

    [Token(Token = "0x6001E5B")]
    [Address(RVA = "0xC273B0", Offset = "0xC261B0", VA = "0x10C273B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InitPlayer value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E5C")]
    [Address(RVA = "0xC27060", Offset = "0xC25E60", VA = "0x10C27060", Slot = "5")]
    public JSON_InitPlayer Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InitPlayer) null;
    }
  }
}
