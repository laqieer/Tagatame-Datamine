// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqWorldRaid_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000890")]
  public sealed class ReqWorldRaid_ResponseFormatter : 
    IMessagePackFormatter<ReqWorldRaid.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015B0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015B1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022FE")]
    [Address(RVA = "0xDAEDC0", Offset = "0xDADBC0", VA = "0x10DAEDC0")]
    public ReqWorldRaid_ResponseFormatter()
    {
    }

    [Token(Token = "0x60022FF")]
    [Address(RVA = "0xDAE970", Offset = "0xDAD770", VA = "0x10DAE970", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqWorldRaid.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002300")]
    [Address(RVA = "0xDAE4C0", Offset = "0xDAD2C0", VA = "0x10DAE4C0", Slot = "5")]
    public ReqWorldRaid.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqWorldRaid.Response) null;
    }
  }
}
