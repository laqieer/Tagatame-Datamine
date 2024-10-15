// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005D8")]
  public sealed class JSON_UnitParamFormatter : 
    IMessagePackFormatter<JSON_UnitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001048")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001049")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AD6")]
    [Address(RVA = "0x961F70", Offset = "0x960D70", VA = "0x10961F70")]
    public JSON_UnitParamFormatter()
    {
    }

    [Token(Token = "0x6001AD7")]
    [Address(RVA = "0x95EC60", Offset = "0x95DA60", VA = "0x1095EC60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AD8")]
    [Address(RVA = "0x95B470", Offset = "0x95A270", VA = "0x1095B470", Slot = "5")]
    public JSON_UnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitParam) null;
    }
  }
}
