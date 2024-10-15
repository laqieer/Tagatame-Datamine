// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneDisassembly_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000996")]
  public sealed class ReqRuneDisassembly_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneDisassembly.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017BC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017BD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002610")]
    [Address(RVA = "0xE42E00", Offset = "0xE41C00", VA = "0x10E42E00")]
    public ReqRuneDisassembly_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002611")]
    [Address(RVA = "0xE42A90", Offset = "0xE41890", VA = "0x10E42A90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneDisassembly.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002612")]
    [Address(RVA = "0xE425E0", Offset = "0xE413E0", VA = "0x10E425E0", Slot = "5")]
    public ReqRuneDisassembly.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneDisassembly.Response) null;
    }
  }
}
