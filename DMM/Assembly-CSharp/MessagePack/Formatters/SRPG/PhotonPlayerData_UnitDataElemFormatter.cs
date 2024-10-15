// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.PhotonPlayerData_UnitDataElemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007F2")]
  public sealed class PhotonPlayerData_UnitDataElemFormatter : 
    IMessagePackFormatter<PhotonPlayerData.UnitDataElem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001474")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001475")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002124")]
    [Address(RVA = "0xD38DC0", Offset = "0xD37BC0", VA = "0x10D38DC0")]
    public PhotonPlayerData_UnitDataElemFormatter()
    {
    }

    [Token(Token = "0x6002125")]
    [Address(RVA = "0xD38AC0", Offset = "0xD378C0", VA = "0x10D38AC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      PhotonPlayerData.UnitDataElem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002126")]
    [Address(RVA = "0xD386E0", Offset = "0xD374E0", VA = "0x10D386E0", Slot = "5")]
    public PhotonPlayerData.UnitDataElem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (PhotonPlayerData.UnitDataElem) null;
    }
  }
}
