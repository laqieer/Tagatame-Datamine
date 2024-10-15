// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeRevivalFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000749")]
  public sealed class MultiPlayResumeRevivalFormatter : 
    IMessagePackFormatter<MultiPlayResumeRevival>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400132A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400132B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F29")]
    [Address(RVA = "0xC8DE00", Offset = "0xC8CC00", VA = "0x10C8DE00")]
    public MultiPlayResumeRevivalFormatter()
    {
    }

    [Token(Token = "0x6001F2A")]
    [Address(RVA = "0xC8DCD0", Offset = "0xC8CAD0", VA = "0x10C8DCD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeRevival value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F2B")]
    [Address(RVA = "0xC8D9C0", Offset = "0xC8C7C0", VA = "0x10C8D9C0", Slot = "5")]
    public MultiPlayResumeRevival Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeRevival) null;
    }
  }
}
