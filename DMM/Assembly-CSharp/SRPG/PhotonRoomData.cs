// Decompiled with JetBrains decompiler
// Type: SRPG.PhotonRoomData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001940")]
  [MessagePackObject(true)]
  public class PhotonRoomData
  {
    [Token(Token = "0x4005B65")]
    public const int ROOMID_VALIDATE_MIN = 0;
    [Token(Token = "0x4005B66")]
    public const int ROOMID_VALIDATE_MAX = 99999;
    [Token(Token = "0x4005B67")]
    [FieldOffset(Offset = "0x8")]
    public string ownerName;
    [Token(Token = "0x4005B68")]
    [FieldOffset(Offset = "0xC")]
    public int ownerLv;
    [Token(Token = "0x4005B69")]
    [FieldOffset(Offset = "0x10")]
    public string ownerFUID;
    [Token(Token = "0x4005B6A")]
    [FieldOffset(Offset = "0x14")]
    public int roomId;
    [Token(Token = "0x4005B6B")]
    [FieldOffset(Offset = "0x18")]
    public string comment;
    [Token(Token = "0x4005B6C")]
    [FieldOffset(Offset = "0x1C")]
    public string passCode;
    [Token(Token = "0x4005B6D")]
    [FieldOffset(Offset = "0x20")]
    public int btlSpd;
    [Token(Token = "0x4005B6E")]
    [FieldOffset(Offset = "0x24")]
    public bool autoAllowed;
    [Token(Token = "0x4005B6F")]
    [FieldOffset(Offset = "0x28")]
    public string btlver;
    [Token(Token = "0x4005B70")]
    [FieldOffset(Offset = "0x2C")]
    public PhotonRoomData.RoomType type;
    [Token(Token = "0x4005B71")]
    [FieldOffset(Offset = "0x30")]
    public bool isLine;
    [Token(Token = "0x4005B72")]
    [FieldOffset(Offset = "0x34")]
    public string questIname;
    [Token(Token = "0x4005B73")]
    [FieldOffset(Offset = "0x38")]
    public bool started;
    [Token(Token = "0x4005B74")]
    [FieldOffset(Offset = "0x39")]
    public bool audienceAllowed;
    [Token(Token = "0x4005B75")]
    [FieldOffset(Offset = "0x3C")]
    public int audienceNum;
    [Token(Token = "0x4005B76")]
    [FieldOffset(Offset = "0x40")]
    public int unitLv;
    [Token(Token = "0x4005B77")]
    [FieldOffset(Offset = "0x44")]
    public int floor;
    [Token(Token = "0x4005B78")]
    [FieldOffset(Offset = "0x48")]
    public VS_MODE vsMode;
    [Token(Token = "0x4005B79")]
    [FieldOffset(Offset = "0x4C")]
    public bool isDraft;
    [Token(Token = "0x4005B7A")]
    [FieldOffset(Offset = "0x50")]
    public int draftDeckId;
    [Token(Token = "0x4005B7B")]
    [FieldOffset(Offset = "0x54")]
    public PhotonPlayerData[] players;
    [Token(Token = "0x4005B7C")]
    [FieldOffset(Offset = "0x58")]
    public PhotonPlayerData[] supports;

    [Token(Token = "0x600669D")]
    [Address(RVA = "0x32C460", Offset = "0x32B260", VA = "0x1032C460")]
    public static PhotonRoomData Create(bool isLine = false) => (PhotonRoomData) null;

    [Token(Token = "0x600669E")]
    [Address(RVA = "0x32CB60", Offset = "0x32B960", VA = "0x1032CB60")]
    public PhotonPlayerData GetHost() => (PhotonPlayerData) null;

    [Token(Token = "0x600669F")]
    [Address(RVA = "0x32CBD0", Offset = "0x32B9D0", VA = "0x1032CBD0")]
    public int GetUnitSlotMax() => new int();

    [Token(Token = "0x60066A0")]
    [Address(RVA = "0x32C210", Offset = "0x32B010", VA = "0x1032C210")]
    public PhotonRoomData Clone() => (PhotonRoomData) null;

    [Token(Token = "0x60066A1")]
    [Address(RVA = "0x32CC30", Offset = "0x32BA30", VA = "0x1032CC30")]
    public PhotonRoomData()
    {
    }

    [Token(Token = "0x2001941")]
    public enum RoomType
    {
      [Token(Token = "0x4005B7E")] Coop,
      [Token(Token = "0x4005B7F")] Versus,
      [Token(Token = "0x4005B80")] Tower,
      [Token(Token = "0x4005B81")] RankMatch,
    }
  }
}
