// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneParamEnhEvo_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200099B")]
  public sealed class ReqRuneParamEnhEvo_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneParamEnhEvo.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017C6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017C7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600261F")]
    [Address(RVA = "0xE472B0", Offset = "0xE460B0", VA = "0x10E472B0")]
    public ReqRuneParamEnhEvo_RequestParamFormatter()
    {
    }

    [Token(Token = "0x6002620")]
    [Address(RVA = "0xE47180", Offset = "0xE45F80", VA = "0x10E47180", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneParamEnhEvo.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002621")]
    [Address(RVA = "0xE46E40", Offset = "0xE45C40", VA = "0x10E46E40", Slot = "5")]
    public ReqRuneParamEnhEvo.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneParamEnhEvo.RequestParam) null;
    }
  }
}
