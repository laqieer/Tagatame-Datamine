// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureDataBaseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005C5")]
  public sealed class JSON_AdventureDataBaseFormatter : 
    IMessagePackFormatter<JSON_AdventureDataBase>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001022")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001023")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A9D")]
    [Address(RVA = "0x94E580", Offset = "0x94D380", VA = "0x1094E580")]
    public JSON_AdventureDataBaseFormatter()
    {
    }

    [Token(Token = "0x6001A9E")]
    [Address(RVA = "0x94E450", Offset = "0x94D250", VA = "0x1094E450", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureDataBase value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A9F")]
    [Address(RVA = "0x94E140", Offset = "0x94CF40", VA = "0x1094E140", Slot = "5")]
    public JSON_AdventureDataBase Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureDataBase) null;
    }
  }
}
