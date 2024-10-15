// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ChatPlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002190")]
  public class JSON_ChatPlayerData
  {
    [Token(Token = "0x40092AD")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x40092AE")]
    [FieldOffset(Offset = "0xC")]
    public int exp;
    [Token(Token = "0x40092AF")]
    [FieldOffset(Offset = "0x10")]
    public long lastlogin;
    [Token(Token = "0x40092B0")]
    [FieldOffset(Offset = "0x18")]
    public byte is_friend;
    [Token(Token = "0x40092B1")]
    [FieldOffset(Offset = "0x19")]
    public byte is_favorite;
    [Token(Token = "0x40092B2")]
    [FieldOffset(Offset = "0x1C")]
    public string fuid;
    [Token(Token = "0x40092B3")]
    [FieldOffset(Offset = "0x20")]
    public Json_Unit unit;
    [Token(Token = "0x40092B4")]
    [FieldOffset(Offset = "0x24")]
    public string award;

    [Token(Token = "0x6008D2D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ChatPlayerData()
    {
    }
  }
}
