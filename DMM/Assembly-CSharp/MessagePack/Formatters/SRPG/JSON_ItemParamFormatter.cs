// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005DE")]
  public sealed class JSON_ItemParamFormatter : 
    IMessagePackFormatter<JSON_ItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001054")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001055")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AE8")]
    [Address(RVA = "0xB3F4A0", Offset = "0xB3E2A0", VA = "0x10B3F4A0")]
    public JSON_ItemParamFormatter()
    {
    }

    [Token(Token = "0x6001AE9")]
    [Address(RVA = "0xB3EB10", Offset = "0xB3D910", VA = "0x10B3EB10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AEA")]
    [Address(RVA = "0xB3E090", Offset = "0xB3CE90", VA = "0x10B3E090", Slot = "5")]
    public JSON_ItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ItemParam) null;
    }
  }
}
