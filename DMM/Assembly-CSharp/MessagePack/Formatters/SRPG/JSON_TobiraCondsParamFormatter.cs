// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TobiraCondsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200060B")]
  public sealed class JSON_TobiraCondsParamFormatter : 
    IMessagePackFormatter<JSON_TobiraCondsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010AE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010AF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B6F")]
    [Address(RVA = "0xBAAB30", Offset = "0xBA9930", VA = "0x10BAAB30")]
    public JSON_TobiraCondsParamFormatter()
    {
    }

    [Token(Token = "0x6001B70")]
    [Address(RVA = "0xBAA910", Offset = "0xBA9710", VA = "0x10BAA910", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TobiraCondsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B71")]
    [Address(RVA = "0xBAA590", Offset = "0xBA9390", VA = "0x10BAA590", Slot = "5")]
    public JSON_TobiraCondsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TobiraCondsParam) null;
    }
  }
}
