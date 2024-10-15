// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000752")]
  public sealed class MultiPlayResumeParamFormatter : 
    IMessagePackFormatter<MultiPlayResumeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400133C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400133D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F44")]
    [Address(RVA = "0xC969E0", Offset = "0xC957E0", VA = "0x10C969E0")]
    public MultiPlayResumeParamFormatter()
    {
    }

    [Token(Token = "0x6001F45")]
    [Address(RVA = "0xC960D0", Offset = "0xC94ED0", VA = "0x10C960D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F46")]
    [Address(RVA = "0xC958F0", Offset = "0xC946F0", VA = "0x10C958F0", Slot = "5")]
    public MultiPlayResumeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeParam) null;
    }
  }
}
