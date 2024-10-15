// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqTrophyStarMission_StarMission_InfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200087D")]
  public sealed class ReqTrophyStarMission_StarMission_InfoFormatter : 
    IMessagePackFormatter<ReqTrophyStarMission.StarMission.Info>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400158A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400158B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022C5")]
    [Address(RVA = "0xDACAD0", Offset = "0xDAB8D0", VA = "0x10DACAD0")]
    public ReqTrophyStarMission_StarMission_InfoFormatter()
    {
    }

    [Token(Token = "0x60022C6")]
    [Address(RVA = "0xDAC880", Offset = "0xDAB680", VA = "0x10DAC880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqTrophyStarMission.StarMission.Info value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022C7")]
    [Address(RVA = "0xDAC4E0", Offset = "0xDAB2E0", VA = "0x10DAC4E0", Slot = "5")]
    public ReqTrophyStarMission.StarMission.Info Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqTrophyStarMission.StarMission.Info) null;
    }
  }
}
