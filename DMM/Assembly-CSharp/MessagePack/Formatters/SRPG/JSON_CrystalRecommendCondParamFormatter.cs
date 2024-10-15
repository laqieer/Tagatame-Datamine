// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalRecommendCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006DA")]
  public sealed class JSON_CrystalRecommendCondParamFormatter : 
    IMessagePackFormatter<JSON_CrystalRecommendCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400124C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400124D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DDC")]
    [Address(RVA = "0xC10430", Offset = "0xC0F230", VA = "0x10C10430")]
    public JSON_CrystalRecommendCondParamFormatter()
    {
    }

    [Token(Token = "0x6001DDD")]
    [Address(RVA = "0xC10250", Offset = "0xC0F050", VA = "0x10C10250", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalRecommendCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DDE")]
    [Address(RVA = "0xC0FEA0", Offset = "0xC0ECA0", VA = "0x10C0FEA0", Slot = "5")]
    public JSON_CrystalRecommendCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalRecommendCondParam) null;
    }
  }
}
