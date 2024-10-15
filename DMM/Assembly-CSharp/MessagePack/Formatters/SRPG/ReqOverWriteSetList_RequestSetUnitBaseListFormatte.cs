// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqOverWriteSetList_RequestSetUnitBaseListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A40")]
  public sealed class ReqOverWriteSetList_RequestSetUnitBaseListFormatter : 
    IMessagePackFormatter<ReqOverWriteSetList.RequestSetUnitBaseList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001910")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001911")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600280E")]
    [Address(RVA = "0xEBB430", Offset = "0xEBA230", VA = "0x10EBB430")]
    public ReqOverWriteSetList_RequestSetUnitBaseListFormatter()
    {
    }

    [Token(Token = "0x600280F")]
    [Address(RVA = "0xEBB170", Offset = "0xEB9F70", VA = "0x10EBB170", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqOverWriteSetList.RequestSetUnitBaseList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002810")]
    [Address(RVA = "0xEBACB0", Offset = "0xEB9AB0", VA = "0x10EBACB0", Slot = "5")]
    public ReqOverWriteSetList.RequestSetUnitBaseList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqOverWriteSetList.RequestSetUnitBaseList) null;
    }
  }
}
