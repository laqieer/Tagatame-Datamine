// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TowerRoundRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200059D")]
  public sealed class JSON_TowerRoundRewardParamFormatter : 
    IMessagePackFormatter<JSON_TowerRoundRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FD2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FD3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A25")]
    [Address(RVA = "0x794BB0", Offset = "0x7939B0", VA = "0x10794BB0")]
    public JSON_TowerRoundRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001A26")]
    [Address(RVA = "0x7949D0", Offset = "0x7937D0", VA = "0x107949D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TowerRoundRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A27")]
    [Address(RVA = "0x794690", Offset = "0x793490", VA = "0x10794690", Slot = "5")]
    public JSON_TowerRoundRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TowerRoundRewardParam) null;
    }
  }
}
