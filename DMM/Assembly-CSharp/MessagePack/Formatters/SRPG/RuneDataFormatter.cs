// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000786")]
  public sealed class RuneDataFormatter : IMessagePackFormatter<RuneData>, IMessagePackFormatter
  {
    [Token(Token = "0x40013A4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013A5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FE0")]
    [Address(RVA = "0xCD1A10", Offset = "0xCD0810", VA = "0x10CD1A10")]
    public RuneDataFormatter()
    {
    }

    [Token(Token = "0x6001FE1")]
    [Address(RVA = "0xCD16F0", Offset = "0xCD04F0", VA = "0x10CD16F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FE2")]
    [Address(RVA = "0xCD1280", Offset = "0xCD0080", VA = "0x10CD1280", Slot = "5")]
    public RuneData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneData) null;
    }
  }
}
