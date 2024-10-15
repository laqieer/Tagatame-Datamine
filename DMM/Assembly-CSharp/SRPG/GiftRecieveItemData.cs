// Decompiled with JetBrains decompiler
// Type: SRPG.GiftRecieveItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200251B")]
  public class GiftRecieveItemData
  {
    [Token(Token = "0x400A99E")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400A99F")]
    [FieldOffset(Offset = "0xC")]
    public int rarity;
    [Token(Token = "0x400A9A0")]
    [FieldOffset(Offset = "0x10")]
    public int num;
    [Token(Token = "0x400A9A1")]
    [FieldOffset(Offset = "0x14")]
    public string name;
    [Token(Token = "0x400A9A2")]
    [FieldOffset(Offset = "0x18")]
    public GiftTypes type;

    [Token(Token = "0x600A317")]
    [Address(RVA = "0x64FEC0", Offset = "0x64ECC0", VA = "0x1064FEC0")]
    public void Set(string iname, GiftTypes giftTipe, int rarity, int num)
    {
    }

    [Token(Token = "0x600A318")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GiftRecieveItemData()
    {
    }
  }
}
