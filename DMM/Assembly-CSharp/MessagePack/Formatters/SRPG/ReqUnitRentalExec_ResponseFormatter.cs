// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqUnitRentalExec_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000881")]
  public sealed class ReqUnitRentalExec_ResponseFormatter : 
    IMessagePackFormatter<ReqUnitRentalExec.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001592")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001593")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022D1")]
    [Address(RVA = "0xDAD100", Offset = "0xDABF00", VA = "0x10DAD100")]
    public ReqUnitRentalExec_ResponseFormatter()
    {
    }

    [Token(Token = "0x60022D2")]
    [Address(RVA = "0xDAD000", Offset = "0xDABE00", VA = "0x10DAD000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqUnitRentalExec.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022D3")]
    [Address(RVA = "0xDACD30", Offset = "0xDABB30", VA = "0x10DACD30", Slot = "5")]
    public ReqUnitRentalExec.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqUnitRentalExec.Response) null;
    }
  }
}
