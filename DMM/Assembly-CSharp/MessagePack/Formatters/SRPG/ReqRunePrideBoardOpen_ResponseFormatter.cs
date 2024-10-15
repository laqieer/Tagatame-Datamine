// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRunePrideBoardOpen_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009A5")]
  public sealed class ReqRunePrideBoardOpen_ResponseFormatter : 
    IMessagePackFormatter<ReqRunePrideBoardOpen.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017DA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017DB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600263D")]
    [Address(RVA = "0xE47870", Offset = "0xE46670", VA = "0x10E47870")]
    public ReqRunePrideBoardOpen_ResponseFormatter()
    {
    }

    [Token(Token = "0x600263E")]
    [Address(RVA = "0xE47770", Offset = "0xE46570", VA = "0x10E47770", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRunePrideBoardOpen.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600263F")]
    [Address(RVA = "0xE474A0", Offset = "0xE462A0", VA = "0x10E474A0", Slot = "5")]
    public ReqRunePrideBoardOpen.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRunePrideBoardOpen.Response) null;
    }
  }
}
