// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGPGSCheckRelate_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008DA")]
  public sealed class ReqGPGSCheckRelate_ResponseFormatter : 
    IMessagePackFormatter<ReqGPGSCheckRelate.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001644")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001645")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023DC")]
    [Address(RVA = "0xDD81C0", Offset = "0xDD6FC0", VA = "0x10DD81C0")]
    public ReqGPGSCheckRelate_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023DD")]
    [Address(RVA = "0xDD8100", Offset = "0xDD6F00", VA = "0x10DD8100", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGPGSCheckRelate.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023DE")]
    [Address(RVA = "0xDD7E60", Offset = "0xDD6C60", VA = "0x10DD7E60", Slot = "5")]
    public ReqGPGSCheckRelate.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGPGSCheckRelate.Response) null;
    }
  }
}
