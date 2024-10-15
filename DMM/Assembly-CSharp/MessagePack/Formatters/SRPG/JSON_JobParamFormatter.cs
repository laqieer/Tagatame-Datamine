// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_JobParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005E3")]
  public sealed class JSON_JobParamFormatter : 
    IMessagePackFormatter<JSON_JobParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400105E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400105F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AF7")]
    [Address(RVA = "0xB42410", Offset = "0xB41210", VA = "0x10B42410")]
    public JSON_JobParamFormatter()
    {
    }

    [Token(Token = "0x6001AF8")]
    [Address(RVA = "0xB41390", Offset = "0xB40190", VA = "0x10B41390", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_JobParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AF9")]
    [Address(RVA = "0xB40240", Offset = "0xB3F040", VA = "0x10B40240", Slot = "5")]
    public JSON_JobParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_JobParam) null;
    }
  }
}
