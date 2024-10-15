// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MultiTowerRewardItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000878")]
  public sealed class JSON_MultiTowerRewardItemFormatter : 
    IMessagePackFormatter<JSON_MultiTowerRewardItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001580")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001581")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022B6")]
    [Address(RVA = "0xD9F4D0", Offset = "0xD9E2D0", VA = "0x10D9F4D0")]
    public JSON_MultiTowerRewardItemFormatter()
    {
    }

    [Token(Token = "0x60022B7")]
    [Address(RVA = "0xD9F300", Offset = "0xD9E100", VA = "0x10D9F300", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MultiTowerRewardItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022B8")]
    [Address(RVA = "0xD9EF50", Offset = "0xD9DD50", VA = "0x10D9EF50", Slot = "5")]
    public JSON_MultiTowerRewardItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MultiTowerRewardItem) null;
    }
  }
}
