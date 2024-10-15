// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.PhotonPlayerStartedFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009D1")]
  public sealed class PhotonPlayerStartedFormatter : 
    IMessagePackFormatter<PhotonPlayerStarted>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001832")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001833")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026C1")]
    [Address(RVA = "0xE75C30", Offset = "0xE74A30", VA = "0x10E75C30")]
    public PhotonPlayerStartedFormatter()
    {
    }

    [Token(Token = "0x60026C2")]
    [Address(RVA = "0xE75A50", Offset = "0xE74850", VA = "0x10E75A50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      PhotonPlayerStarted value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026C3")]
    [Address(RVA = "0xE75710", Offset = "0xE74510", VA = "0x10E75710", Slot = "5")]
    public PhotonPlayerStarted Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (PhotonPlayerStarted) null;
    }
  }
}
