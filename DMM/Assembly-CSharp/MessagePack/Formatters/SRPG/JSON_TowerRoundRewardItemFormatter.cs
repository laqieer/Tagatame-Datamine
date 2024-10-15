// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TowerRoundRewardItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200059C")]
  public sealed class JSON_TowerRoundRewardItemFormatter : 
    IMessagePackFormatter<JSON_TowerRoundRewardItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FD0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FD1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A22")]
    [Address(RVA = "0x7943C0", Offset = "0x7931C0", VA = "0x107943C0")]
    public JSON_TowerRoundRewardItemFormatter()
    {
    }

    [Token(Token = "0x6001A23")]
    [Address(RVA = "0x7941D0", Offset = "0x792FD0", VA = "0x107941D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TowerRoundRewardItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A24")]
    [Address(RVA = "0x793E20", Offset = "0x792C20", VA = "0x10793E20", Slot = "5")]
    public JSON_TowerRoundRewardItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TowerRoundRewardItem) null;
    }
  }
}
