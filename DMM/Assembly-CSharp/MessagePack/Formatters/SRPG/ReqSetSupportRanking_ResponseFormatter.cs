// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqSetSupportRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009B6")]
  public sealed class ReqSetSupportRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqSetSupportRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017FC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017FD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002670")]
    [Address(RVA = "0xE4BE90", Offset = "0xE4AC90", VA = "0x10E4BE90")]
    public ReqSetSupportRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002671")]
    [Address(RVA = "0xE4BBE0", Offset = "0xE4A9E0", VA = "0x10E4BBE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqSetSupportRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002672")]
    [Address(RVA = "0xE4B830", Offset = "0xE4A630", VA = "0x10E4B830", Slot = "5")]
    public ReqSetSupportRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqSetSupportRanking.Response) null;
    }
  }
}
