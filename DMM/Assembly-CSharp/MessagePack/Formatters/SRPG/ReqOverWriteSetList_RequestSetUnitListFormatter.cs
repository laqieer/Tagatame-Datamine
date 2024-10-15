// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqOverWriteSetList_RequestSetUnitListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A3F")]
  public sealed class ReqOverWriteSetList_RequestSetUnitListFormatter : 
    IMessagePackFormatter<ReqOverWriteSetList.RequestSetUnitList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400190E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400190F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600280B")]
    [Address(RVA = "0xEBC000", Offset = "0xEBAE00", VA = "0x10EBC000")]
    public ReqOverWriteSetList_RequestSetUnitListFormatter()
    {
    }

    [Token(Token = "0x600280C")]
    [Address(RVA = "0xEBBCD0", Offset = "0xEBAAD0", VA = "0x10EBBCD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqOverWriteSetList.RequestSetUnitList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600280D")]
    [Address(RVA = "0xEBB7D0", Offset = "0xEBA5D0", VA = "0x10EBB7D0", Slot = "5")]
    public ReqOverWriteSetList.RequestSetUnitList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqOverWriteSetList.RequestSetUnitList) null;
    }
  }
}
