// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayTrickParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000750")]
  public sealed class MultiPlayTrickParamFormatter : 
    IMessagePackFormatter<MultiPlayTrickParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001338")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001339")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F3E")]
    [Address(RVA = "0xC94390", Offset = "0xC93190", VA = "0x10C94390")]
    public MultiPlayTrickParamFormatter()
    {
    }

    [Token(Token = "0x6001F3F")]
    [Address(RVA = "0xC94070", Offset = "0xC92E70", VA = "0x10C94070", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayTrickParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F40")]
    [Address(RVA = "0xC93B80", Offset = "0xC92980", VA = "0x10C93B80", Slot = "5")]
    public MultiPlayTrickParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayTrickParam) null;
    }
  }
}
