// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqSetAutoRuneDisassembly_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009A2")]
  public sealed class ReqSetAutoRuneDisassembly_RequestParamFormatter : 
    IMessagePackFormatter<ReqSetAutoRuneDisassembly.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017D4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017D5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002634")]
    [Address(RVA = "0xE4A7D0", Offset = "0xE495D0", VA = "0x10E4A7D0")]
    public ReqSetAutoRuneDisassembly_RequestParamFormatter()
    {
    }

    [Token(Token = "0x6002635")]
    [Address(RVA = "0xE4A6D0", Offset = "0xE494D0", VA = "0x10E4A6D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqSetAutoRuneDisassembly.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002636")]
    [Address(RVA = "0xE4A400", Offset = "0xE49200", VA = "0x10E4A400", Slot = "5")]
    public ReqSetAutoRuneDisassembly.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqSetAutoRuneDisassembly.RequestParam) null;
    }
  }
}
