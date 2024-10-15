// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGUnitOverWriteDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005D5")]
  public sealed class JSON_GvGUnitOverWriteDataFormatter : 
    IMessagePackFormatter<JSON_GvGUnitOverWriteData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001042")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001043")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001ACD")]
    [Address(RVA = "0x959A20", Offset = "0x958820", VA = "0x10959A20")]
    public JSON_GvGUnitOverWriteDataFormatter()
    {
    }

    [Token(Token = "0x6001ACE")]
    [Address(RVA = "0x959680", Offset = "0x958480", VA = "0x10959680", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGUnitOverWriteData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ACF")]
    [Address(RVA = "0x959100", Offset = "0x957F00", VA = "0x10959100", Slot = "5")]
    public JSON_GvGUnitOverWriteData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGUnitOverWriteData) null;
    }
  }
}
