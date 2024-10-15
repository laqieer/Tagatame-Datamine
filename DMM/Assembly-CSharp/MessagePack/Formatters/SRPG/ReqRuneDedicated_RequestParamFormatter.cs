// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneDedicated_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200099E")]
  public sealed class ReqRuneDedicated_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneDedicated.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017CC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017CD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002628")]
    [Address(RVA = "0xE41F70", Offset = "0xE40D70", VA = "0x10E41F70")]
    public ReqRuneDedicated_RequestParamFormatter()
    {
    }

    [Token(Token = "0x6002629")]
    [Address(RVA = "0xE41E70", Offset = "0xE40C70", VA = "0x10E41E70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneDedicated.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600262A")]
    [Address(RVA = "0xE41B50", Offset = "0xE40950", VA = "0x10E41B50", Slot = "5")]
    public ReqRuneDedicated.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneDedicated.RequestParam) null;
    }
  }
}
