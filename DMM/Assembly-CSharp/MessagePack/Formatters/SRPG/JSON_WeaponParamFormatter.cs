// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WeaponParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005E0")]
  public sealed class JSON_WeaponParamFormatter : 
    IMessagePackFormatter<JSON_WeaponParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001058")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001059")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AEE")]
    [Address(RVA = "0xB462C0", Offset = "0xB450C0", VA = "0x10B462C0")]
    public JSON_WeaponParamFormatter()
    {
    }

    [Token(Token = "0x6001AEF")]
    [Address(RVA = "0xB46160", Offset = "0xB44F60", VA = "0x10B46160", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WeaponParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AF0")]
    [Address(RVA = "0xB45E10", Offset = "0xB44C10", VA = "0x10B45E10", Slot = "5")]
    public JSON_WeaponParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WeaponParam) null;
    }
  }
}
