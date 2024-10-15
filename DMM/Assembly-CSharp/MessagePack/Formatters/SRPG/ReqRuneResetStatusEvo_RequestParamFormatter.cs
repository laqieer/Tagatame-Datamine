// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneResetStatusEvo_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000999")]
  public sealed class ReqRuneResetStatusEvo_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneResetStatusEvo.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017C2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017C3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002619")]
    [Address(RVA = "0xE49AA0", Offset = "0xE488A0", VA = "0x10E49AA0")]
    public ReqRuneResetStatusEvo_RequestParamFormatter()
    {
    }

    [Token(Token = "0x600261A")]
    [Address(RVA = "0xE49970", Offset = "0xE48770", VA = "0x10E49970", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneResetStatusEvo.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600261B")]
    [Address(RVA = "0xE49630", Offset = "0xE48430", VA = "0x10E49630", Slot = "5")]
    public ReqRuneResetStatusEvo.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneResetStatusEvo.RequestParam) null;
    }
  }
}
