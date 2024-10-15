// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqUnitRentalAdd_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AD4")]
  public sealed class ReqUnitRentalAdd_ResponseFormatter : 
    IMessagePackFormatter<ReqUnitRentalAdd.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A38")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A39")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029CA")]
    [Address(RVA = "0xF17E30", Offset = "0xF16C30", VA = "0x10F17E30")]
    public ReqUnitRentalAdd_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029CB")]
    [Address(RVA = "0xF17D30", Offset = "0xF16B30", VA = "0x10F17D30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqUnitRentalAdd.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029CC")]
    [Address(RVA = "0xF17A60", Offset = "0xF16860", VA = "0x10F17A60", Slot = "5")]
    public ReqUnitRentalAdd.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqUnitRentalAdd.Response) null;
    }
  }
}
