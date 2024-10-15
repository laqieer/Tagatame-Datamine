// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqTrophyStarMission_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000937")]
  public sealed class ReqTrophyStarMission_ResponseFormatter : 
    IMessagePackFormatter<ReqTrophyStarMission.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016FE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016FF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024F3")]
    [Address(RVA = "0xE07E50", Offset = "0xE06C50", VA = "0x10E07E50")]
    public ReqTrophyStarMission_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024F4")]
    [Address(RVA = "0xE07CE0", Offset = "0xE06AE0", VA = "0x10E07CE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqTrophyStarMission.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024F5")]
    [Address(RVA = "0xE07A10", Offset = "0xE06810", VA = "0x10E07A10", Slot = "5")]
    public ReqTrophyStarMission.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqTrophyStarMission.Response) null;
    }
  }
}
