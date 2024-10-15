// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqTrophyStarMission_StarMissionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200087E")]
  public sealed class ReqTrophyStarMission_StarMissionFormatter : 
    IMessagePackFormatter<ReqTrophyStarMission.StarMission>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400158C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400158D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022C8")]
    [Address(RVA = "0xDAC360", Offset = "0xDAB160", VA = "0x10DAC360")]
    public ReqTrophyStarMission_StarMissionFormatter()
    {
    }

    [Token(Token = "0x60022C9")]
    [Address(RVA = "0xDAC210", Offset = "0xDAB010", VA = "0x10DAC210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqTrophyStarMission.StarMission value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022CA")]
    [Address(RVA = "0xDABEE0", Offset = "0xDAACE0", VA = "0x10DABEE0", Slot = "5")]
    public ReqTrophyStarMission.StarMission Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqTrophyStarMission.StarMission) null;
    }
  }
}
