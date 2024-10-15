// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqOverWriteSetList_ReqOverWriteSetListResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A42")]
  public sealed class ReqOverWriteSetList_ReqOverWriteSetListResponseFormatter : 
    IMessagePackFormatter<ReqOverWriteSetList.ReqOverWriteSetListResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001914")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001915")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002814")]
    [Address(RVA = "0xEBA980", Offset = "0xEB9780", VA = "0x10EBA980")]
    public ReqOverWriteSetList_ReqOverWriteSetListResponseFormatter()
    {
    }

    [Token(Token = "0x6002815")]
    [Address(RVA = "0xEBA690", Offset = "0xEB9490", VA = "0x10EBA690", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqOverWriteSetList.ReqOverWriteSetListResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002816")]
    [Address(RVA = "0xEBA260", Offset = "0xEB9060", VA = "0x10EBA260", Slot = "5")]
    public ReqOverWriteSetList.ReqOverWriteSetListResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqOverWriteSetList.ReqOverWriteSetListResponse) null;
    }
  }
}
