// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MapParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200084B")]
  public sealed class JSON_MapParamFormatter : 
    IMessagePackFormatter<JSON_MapParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001526")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001527")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600222F")]
    [Address(RVA = "0xD72A80", Offset = "0xD71880", VA = "0x10D72A80")]
    public JSON_MapParamFormatter()
    {
    }

    [Token(Token = "0x6002230")]
    [Address(RVA = "0xD72810", Offset = "0xD71610", VA = "0x10D72810", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MapParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002231")]
    [Address(RVA = "0xD723F0", Offset = "0xD711F0", VA = "0x10D723F0", Slot = "5")]
    public JSON_MapParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MapParam) null;
    }
  }
}
