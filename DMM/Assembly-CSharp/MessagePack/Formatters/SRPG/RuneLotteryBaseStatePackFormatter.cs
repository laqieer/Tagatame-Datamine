// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneLotteryBaseStatePackFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008FD")]
  public sealed class RuneLotteryBaseStatePackFormatter : 
    IMessagePackFormatter<RuneLotteryBaseStatePack>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400168A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400168B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002445")]
    [Address(RVA = "0xDEF1B0", Offset = "0xDEDFB0", VA = "0x10DEF1B0")]
    public RuneLotteryBaseStatePackFormatter()
    {
    }

    [Token(Token = "0x6002446")]
    [Address(RVA = "0xDEEFC0", Offset = "0xDEDDC0", VA = "0x10DEEFC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneLotteryBaseStatePack value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002447")]
    [Address(RVA = "0xDEEC20", Offset = "0xDEDA20", VA = "0x10DEEC20", Slot = "5")]
    public RuneLotteryBaseStatePack Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneLotteryBaseStatePack) null;
    }
  }
}
