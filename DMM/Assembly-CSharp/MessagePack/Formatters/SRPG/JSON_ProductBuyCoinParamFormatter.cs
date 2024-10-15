// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ProductBuyCoinParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B2B")]
  public sealed class JSON_ProductBuyCoinParamFormatter : 
    IMessagePackFormatter<JSON_ProductBuyCoinParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AE6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AE7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002ACF")]
    [Address(RVA = "0xF66BF0", Offset = "0xF659F0", VA = "0x10F66BF0")]
    public JSON_ProductBuyCoinParamFormatter()
    {
    }

    [Token(Token = "0x6002AD0")]
    [Address(RVA = "0xF66A30", Offset = "0xF65830", VA = "0x10F66A30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ProductBuyCoinParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AD1")]
    [Address(RVA = "0xF666A0", Offset = "0xF654A0", VA = "0x10F666A0", Slot = "5")]
    public JSON_ProductBuyCoinParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ProductBuyCoinParam) null;
    }
  }
}
