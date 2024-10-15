// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqUnitTruthEquipLvup_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AA9")]
  public sealed class ReqUnitTruthEquipLvup_ResponseFormatter : 
    IMessagePackFormatter<ReqUnitTruthEquipLvup.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019E2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019E3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002949")]
    [Address(RVA = "0xF00330", Offset = "0xEFF130", VA = "0x10F00330")]
    public ReqUnitTruthEquipLvup_ResponseFormatter()
    {
    }

    [Token(Token = "0x600294A")]
    [Address(RVA = "0xF00160", Offset = "0xEFEF60", VA = "0x10F00160", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqUnitTruthEquipLvup.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600294B")]
    [Address(RVA = "0xEFFDB0", Offset = "0xEFEBB0", VA = "0x10EFFDB0", Slot = "5")]
    public ReqUnitTruthEquipLvup.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqUnitTruthEquipLvup.Response) null;
    }
  }
}
