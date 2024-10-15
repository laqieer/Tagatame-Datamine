// Decompiled with JetBrains decompiler
// Type: SRPG.PhotonPlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001944")]
  [MessagePackObject(true)]
  public class PhotonPlayerData
  {
    [Token(Token = "0x4005B88")]
    [FieldOffset(Offset = "0x8")]
    public PhotonPlayerData.PlayerState state;
    [Token(Token = "0x4005B89")]
    [FieldOffset(Offset = "0xC")]
    public int photonPlayerID;
    [Token(Token = "0x4005B8A")]
    [FieldOffset(Offset = "0x10")]
    public int seat;
    [Token(Token = "0x4005B8B")]
    [FieldOffset(Offset = "0x14")]
    public string playerName;
    [Token(Token = "0x4005B8C")]
    [FieldOffset(Offset = "0x18")]
    public int playerLv;
    [Token(Token = "0x4005B8D")]
    [FieldOffset(Offset = "0x1C")]
    public string FUID;
    [Token(Token = "0x4005B8E")]
    [FieldOffset(Offset = "0x20")]
    public string UID;
    [Token(Token = "0x4005B8F")]
    [FieldOffset(Offset = "0x24")]
    public string awardIname;
    [Token(Token = "0x4005B90")]
    [FieldOffset(Offset = "0x28")]
    public int guildId;
    [Token(Token = "0x4005B91")]
    [FieldOffset(Offset = "0x2C")]
    public string guildName;
    [Token(Token = "0x4005B92")]
    [FieldOffset(Offset = "0x30")]
    public bool isSupportAI;
    [Token(Token = "0x4005B93")]
    [FieldOffset(Offset = "0x31")]
    public bool isAuto;
    [Token(Token = "0x4005B94")]
    [FieldOffset(Offset = "0x32")]
    public bool isAutoTreasure;
    [Token(Token = "0x4005B95")]
    [FieldOffset(Offset = "0x33")]
    public bool isAutoNoSkill;
    [Token(Token = "0x4005B96")]
    [FieldOffset(Offset = "0x34")]
    public int totalAtk;
    [Token(Token = "0x4005B97")]
    [FieldOffset(Offset = "0x38")]
    public int totalStatus;
    [Token(Token = "0x4005B98")]
    [FieldOffset(Offset = "0x3C")]
    public int towerChallengeFloor;
    [Token(Token = "0x4005B99")]
    [FieldOffset(Offset = "0x40")]
    public int towerClearedFloor;
    [Token(Token = "0x4005B9A")]
    [FieldOffset(Offset = "0x44")]
    public int rankMatchScore;
    [Token(Token = "0x4005B9B")]
    [FieldOffset(Offset = "0x48")]
    public int draftId;
    [Token(Token = "0x4005B9C")]
    [FieldOffset(Offset = "0x4C")]
    public string draftLeaderUnit;
    [Token(Token = "0x4005B9D")]
    [FieldOffset(Offset = "0x50")]
    public PhotonPlayerData.UnitDataElem[] units;

    [Token(Token = "0x17000A56")]
    public bool IsStateReady
    {
      [Token(Token = "0x60066A8"), Address(RVA = "0x32C030", Offset = "0x32AE30", VA = "0x1032C030")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60066A9")]
    [Address(RVA = "0x32AE90", Offset = "0x329C90", VA = "0x1032AE90")]
    public static PhotonPlayerData Create(int playerID = 0, int seat = 0)
    {
      return (PhotonPlayerData) null;
    }

    [Token(Token = "0x60066AA")]
    [Address(RVA = "0x32ABE0", Offset = "0x3299E0", VA = "0x1032ABE0")]
    public static PhotonPlayerData CreateSupportAI(
      MultiSupportData support,
      int seat,
      int photonPlayerID)
    {
      return (PhotonPlayerData) null;
    }

    [Token(Token = "0x60066AB")]
    [Address(RVA = "0x32BD90", Offset = "0x32AB90", VA = "0x1032BD90")]
    public void UpdateUnitPlacement(bool isDefault)
    {
    }

    [Token(Token = "0x60066AC")]
    [Address(RVA = "0x32BA80", Offset = "0x32A880", VA = "0x1032BA80")]
    public bool Equals(PhotonPlayerData obj) => new bool();

    [Token(Token = "0x60066AD")]
    [Address(RVA = "0x32A9A0", Offset = "0x3297A0", VA = "0x1032A9A0")]
    public PhotonPlayerData Clone() => (PhotonPlayerData) null;

    [Token(Token = "0x60066AE")]
    [Address(RVA = "0x32BC90", Offset = "0x32AA90", VA = "0x1032BC90", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x60066AF")]
    [Address(RVA = "0x32BF70", Offset = "0x32AD70", VA = "0x1032BF70")]
    public PhotonPlayerData()
    {
    }

    [Token(Token = "0x2001945")]
    [MessagePackObject(true)]
    public class UnitDataElem
    {
      [Token(Token = "0x4005B9E")]
      [FieldOffset(Offset = "0x8")]
      public int slot;
      [Token(Token = "0x4005B9F")]
      [FieldOffset(Offset = "0xC")]
      public int place;
      [Token(Token = "0x4005BA0")]
      [FieldOffset(Offset = "0x10")]
      public bool isSub;
      [Token(Token = "0x4005BA1")]
      [FieldOffset(Offset = "0x14")]
      public Json_Unit unitJson;
      [Token(Token = "0x4005BA2")]
      [FieldOffset(Offset = "0x18")]
      public JSON_PlayerBuff playerBuff;
      [Token(Token = "0x4005BA3")]
      [FieldOffset(Offset = "0x1C")]
      private UnitData _unit;

      [Token(Token = "0x17000A57")]
      [IgnoreMember]
      public UnitData unit
      {
        [Token(Token = "0x60066B0"), Address(RVA = "0x32EB80", Offset = "0x32D980", VA = "0x1032EB80")] get
        {
          return (UnitData) null;
        }
        [Token(Token = "0x60066B1"), Address(RVA = "0x32EC10", Offset = "0x32DA10", VA = "0x1032EC10")] set
        {
        }
      }

      [Token(Token = "0x60066B2")]
      [Address(RVA = "0x32EAB0", Offset = "0x32D8B0", VA = "0x1032EAB0")]
      public PhotonPlayerData.UnitDataElem Clone() => (PhotonPlayerData.UnitDataElem) null;

      [Token(Token = "0x60066B3")]
      [Address(RVA = "0x32C120", Offset = "0x32AF20", VA = "0x1032C120")]
      public UnitDataElem()
      {
      }
    }

    [Token(Token = "0x2001946")]
    public enum PlayerState
    {
      [Token(Token = "0x4005BA5")] None,
      [Token(Token = "0x4005BA6")] Ready,
      [Token(Token = "0x4005BA7")] Start,
      [Token(Token = "0x4005BA8")] StartConfirm,
      [Token(Token = "0x4005BA9")] Edit,
      [Token(Token = "0x4005BAA")] FloorSelect,
    }
  }
}
