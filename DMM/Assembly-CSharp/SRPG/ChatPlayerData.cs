// Decompiled with JetBrains decompiler
// Type: SRPG.ChatPlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002191")]
  public class ChatPlayerData
  {
    [Token(Token = "0x40092B5")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x40092B6")]
    [FieldOffset(Offset = "0xC")]
    public int exp;
    [Token(Token = "0x40092B7")]
    [FieldOffset(Offset = "0x10")]
    public UnitData unit;
    [Token(Token = "0x40092B8")]
    [FieldOffset(Offset = "0x18")]
    public long lastlogin;
    [Token(Token = "0x40092B9")]
    [FieldOffset(Offset = "0x20")]
    public byte is_friend;
    [Token(Token = "0x40092BA")]
    [FieldOffset(Offset = "0x21")]
    public byte is_favorite;
    [Token(Token = "0x40092BB")]
    [FieldOffset(Offset = "0x24")]
    public string fuid;
    [Token(Token = "0x40092BC")]
    [FieldOffset(Offset = "0x28")]
    public int lv;
    [Token(Token = "0x40092BD")]
    [FieldOffset(Offset = "0x2C")]
    public string award;

    [Token(Token = "0x170013E9")]
    public bool IsFriend
    {
      [Token(Token = "0x6008D2E"), Address(RVA = "0x50DA20", Offset = "0x50C820", VA = "0x1050DA20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013EA")]
    public bool IsFavorite
    {
      [Token(Token = "0x6008D2F"), Address(RVA = "0x50DA10", Offset = "0x50C810", VA = "0x1050DA10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008D30")]
    [Address(RVA = "0x50D810", Offset = "0x50C610", VA = "0x1050D810")]
    public void Deserialize(JSON_ChatPlayerData json)
    {
    }

    [Token(Token = "0x6008D31")]
    [Address(RVA = "0x50D910", Offset = "0x50C710", VA = "0x1050D910")]
    public FriendData ToFriendData() => (FriendData) null;

    [Token(Token = "0x6008D32")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChatPlayerData()
    {
    }
  }
}
