// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqSetAutoRuneDisassembly_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009A3")]
  public sealed class ReqSetAutoRuneDisassembly_ResponseFormatter : 
    IMessagePackFormatter<ReqSetAutoRuneDisassembly.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017D6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017D7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002637")]
    [Address(RVA = "0xE4ACC0", Offset = "0xE49AC0", VA = "0x10E4ACC0")]
    public ReqSetAutoRuneDisassembly_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002638")]
    [Address(RVA = "0xE4ABC0", Offset = "0xE499C0", VA = "0x10E4ABC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqSetAutoRuneDisassembly.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002639")]
    [Address(RVA = "0xE4A8F0", Offset = "0xE496F0", VA = "0x10E4A8F0", Slot = "5")]
    public ReqSetAutoRuneDisassembly.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqSetAutoRuneDisassembly.Response) null;
    }
  }
}
