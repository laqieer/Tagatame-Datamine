// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneContinueReinforcement_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000993")]
  public sealed class ReqRuneContinueReinforcement_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneContinueReinforcement.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017B6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017B7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002607")]
    [Address(RVA = "0xE41960", Offset = "0xE40760", VA = "0x10E41960")]
    public ReqRuneContinueReinforcement_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002608")]
    [Address(RVA = "0xE41790", Offset = "0xE40590", VA = "0x10E41790", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneContinueReinforcement.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002609")]
    [Address(RVA = "0xE413E0", Offset = "0xE401E0", VA = "0x10E413E0", Slot = "5")]
    public ReqRuneContinueReinforcement.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneContinueReinforcement.Response) null;
    }
  }
}
