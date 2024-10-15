// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureNumParam_AdvCondFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000952")]
  public sealed class JSON_AdventureNumParam_AdvCondFormatter : 
    IMessagePackFormatter<JSON_AdventureNumParam.AdvCond>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001734")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001735")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002544")]
    [Address(RVA = "0xE14460", Offset = "0xE13260", VA = "0x10E14460")]
    public JSON_AdventureNumParam_AdvCondFormatter()
    {
    }

    [Token(Token = "0x6002545")]
    [Address(RVA = "0xE14360", Offset = "0xE13160", VA = "0x10E14360", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureNumParam.AdvCond value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002546")]
    [Address(RVA = "0xE14080", Offset = "0xE12E80", VA = "0x10E14080", Slot = "5")]
    public JSON_AdventureNumParam.AdvCond Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureNumParam.AdvCond) null;
    }
  }
}
