// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneResetStatusEvo_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200099A")]
  public sealed class ReqRuneResetStatusEvo_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneResetStatusEvo.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017C4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017C5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600261C")]
    [Address(RVA = "0xE4A210", Offset = "0xE49010", VA = "0x10E4A210")]
    public ReqRuneResetStatusEvo_ResponseFormatter()
    {
    }

    [Token(Token = "0x600261D")]
    [Address(RVA = "0xE4A040", Offset = "0xE48E40", VA = "0x10E4A040", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneResetStatusEvo.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600261E")]
    [Address(RVA = "0xE49C90", Offset = "0xE48A90", VA = "0x10E49C90", Slot = "5")]
    public ReqRuneResetStatusEvo.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneResetStatusEvo.Response) null;
    }
  }
}
