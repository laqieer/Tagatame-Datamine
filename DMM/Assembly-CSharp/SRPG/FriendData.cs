// Decompiled with JetBrains decompiler
// Type: SRPG.FriendData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001037")]
  public class FriendData
  {
    [Token(Token = "0x40039AD")]
    [FieldOffset(Offset = "0x8")]
    public UnitData Unit;
    [Token(Token = "0x40039AE")]
    [FieldOffset(Offset = "0xC")]
    public FriendStates State;
    [Token(Token = "0x40039AF")]
    [FieldOffset(Offset = "0x10")]
    public string UID;
    [Token(Token = "0x40039B0")]
    [FieldOffset(Offset = "0x14")]
    public string FUID;
    [Token(Token = "0x40039B1")]
    [FieldOffset(Offset = "0x18")]
    public string PlayerName;
    [Token(Token = "0x40039B2")]
    [FieldOffset(Offset = "0x1C")]
    public int PlayerLevel;
    [Token(Token = "0x40039B3")]
    [FieldOffset(Offset = "0x20")]
    public long LastLogin;
    [Token(Token = "0x40039B4")]
    [FieldOffset(Offset = "0x28")]
    public string CreatedAt;
    [Token(Token = "0x40039B5")]
    [FieldOffset(Offset = "0x2C")]
    public bool IsFavorite;
    [Token(Token = "0x40039B6")]
    [FieldOffset(Offset = "0x30")]
    public string UnitID;
    [Token(Token = "0x40039B7")]
    [FieldOffset(Offset = "0x34")]
    public int UnitLevel;
    [Token(Token = "0x40039B8")]
    [FieldOffset(Offset = "0x38")]
    public int UnitRarity;
    [Token(Token = "0x40039B9")]
    [FieldOffset(Offset = "0x3C")]
    public string SelectAward;
    [Token(Token = "0x40039BA")]
    [FieldOffset(Offset = "0x40")]
    public string Wish;
    [Token(Token = "0x40039BB")]
    [FieldOffset(Offset = "0x44")]
    public string WishStatus;
    [Token(Token = "0x40039BC")]
    [FieldOffset(Offset = "0x48")]
    public bool MultiPush;
    [Token(Token = "0x40039BD")]
    [FieldOffset(Offset = "0x4C")]
    public string MultiComment;
    [Token(Token = "0x40039BE")]
    [FieldOffset(Offset = "0x50")]
    public ViewGuildData ViewGuild;

    [Token(Token = "0x17000612")]
    public EElement UnitElement
    {
      [Token(Token = "0x600429B"), Address(RVA = "0x11DCEA0", Offset = "0x11DBCA0", VA = "0x111DCEA0")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x600429C")]
    [Address(RVA = "0x11DCB90", Offset = "0x11DB990", VA = "0x111DCB90")]
    public void Deserialize(Json_Friend json)
    {
    }

    [Token(Token = "0x600429D")]
    [Address(RVA = "0x7C1EC0", Offset = "0x7C0CC0", VA = "0x107C1EC0")]
    public bool IsFriend() => new bool();

    [Token(Token = "0x600429E")]
    [Address(RVA = "0x11DCE00", Offset = "0x11DBC00", VA = "0x111DCE00")]
    public int GetCost() => new int();

    [Token(Token = "0x600429F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FriendData()
    {
    }
  }
}
