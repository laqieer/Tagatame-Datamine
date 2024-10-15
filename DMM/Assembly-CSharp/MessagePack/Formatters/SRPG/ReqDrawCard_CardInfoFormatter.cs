// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqDrawCard_CardInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A38")]
  public sealed class ReqDrawCard_CardInfoFormatter : 
    IMessagePackFormatter<ReqDrawCard.CardInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001900")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001901")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027F6")]
    [Address(RVA = "0xEB5900", Offset = "0xEB4700", VA = "0x10EB5900")]
    public ReqDrawCard_CardInfoFormatter()
    {
    }

    [Token(Token = "0x60027F7")]
    [Address(RVA = "0xEB5760", Offset = "0xEB4560", VA = "0x10EB5760", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqDrawCard.CardInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027F8")]
    [Address(RVA = "0xEB5450", Offset = "0xEB4250", VA = "0x10EB5450", Slot = "5")]
    public ReqDrawCard.CardInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqDrawCard.CardInfo) null;
    }
  }
}
