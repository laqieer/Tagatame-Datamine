// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqDrawCard_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A3A")]
  public sealed class ReqDrawCard_ResponseFormatter : 
    IMessagePackFormatter<ReqDrawCard.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001904")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001905")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027FC")]
    [Address(RVA = "0xEB6690", Offset = "0xEB5490", VA = "0x10EB6690")]
    public ReqDrawCard_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027FD")]
    [Address(RVA = "0xEB6460", Offset = "0xEB5260", VA = "0x10EB6460", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqDrawCard.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027FE")]
    [Address(RVA = "0xEB6120", Offset = "0xEB4F20", VA = "0x10EB6120", Slot = "5")]
    public ReqDrawCard.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqDrawCard.Response) null;
    }
  }
}
