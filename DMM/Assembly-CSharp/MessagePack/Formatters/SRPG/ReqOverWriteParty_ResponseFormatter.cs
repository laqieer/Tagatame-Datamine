// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqOverWriteParty_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AAB")]
  public sealed class ReqOverWriteParty_ResponseFormatter : 
    IMessagePackFormatter<ReqOverWriteParty.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019E6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019E7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600294F")]
    [Address(RVA = "0xEFFC90", Offset = "0xEFEA90", VA = "0x10EFFC90")]
    public ReqOverWriteParty_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002950")]
    [Address(RVA = "0xEFFB20", Offset = "0xEFE920", VA = "0x10EFFB20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqOverWriteParty.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002951")]
    [Address(RVA = "0xEFF850", Offset = "0xEFE650", VA = "0x10EFF850", Slot = "5")]
    public ReqOverWriteParty.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqOverWriteParty.Response) null;
    }
  }
}
