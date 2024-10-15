// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayAPIRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200193C")]
  public class MultiPlayAPIRoom
  {
    [Token(Token = "0x4005B45")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string LOCKED;
    [Token(Token = "0x4005B46")]
    [FieldOffset(Offset = "0x8")]
    public int roomid;
    [Token(Token = "0x4005B47")]
    [FieldOffset(Offset = "0xC")]
    public string comment;
    [Token(Token = "0x4005B48")]
    [FieldOffset(Offset = "0x10")]
    public MultiPlayAPIRoom.Quest quest;
    [Token(Token = "0x4005B49")]
    [FieldOffset(Offset = "0x14")]
    public string pwd_hash;
    [Token(Token = "0x4005B4A")]
    [FieldOffset(Offset = "0x18")]
    public int limit;
    [Token(Token = "0x4005B4B")]
    [FieldOffset(Offset = "0x1C")]
    public int unitlv;
    [Token(Token = "0x4005B4C")]
    [FieldOffset(Offset = "0x20")]
    public int clear;
    [Token(Token = "0x4005B4D")]
    [FieldOffset(Offset = "0x24")]
    public int is_clear;
    [Token(Token = "0x4005B4E")]
    [FieldOffset(Offset = "0x28")]
    public int floor;
    [Token(Token = "0x4005B4F")]
    [FieldOffset(Offset = "0x2C")]
    public int btl_speed;
    [Token(Token = "0x4005B50")]
    [FieldOffset(Offset = "0x30")]
    public int enable_auto;
    [Token(Token = "0x4005B51")]
    [FieldOffset(Offset = "0x34")]
    public string network_version;
    [Token(Token = "0x4005B52")]
    [FieldOffset(Offset = "0x38")]
    public int num;
    [Token(Token = "0x4005B53")]
    [FieldOffset(Offset = "0x3C")]
    public MultiPlayAPIRoom.Owner owner;

    [Token(Token = "0x6006695")]
    [Address(RVA = "0x321800", Offset = "0x320600", VA = "0x10321800")]
    public static string CalcHash(string pwd) => (string) null;

    [Token(Token = "0x6006696")]
    [Address(RVA = "0x321940", Offset = "0x320740", VA = "0x10321940")]
    public static bool IsLocked(string pwd) => new bool();

    [Token(Token = "0x6006697")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiPlayAPIRoom()
    {
    }

    [Token(Token = "0x6006698")]
    [Address(RVA = "0x321990", Offset = "0x320790", VA = "0x10321990")]
    static MultiPlayAPIRoom()
    {
    }

    [Token(Token = "0x200193D")]
    public class Quest
    {
      [Token(Token = "0x4005B54")]
      [FieldOffset(Offset = "0x8")]
      public string iname;

      [Token(Token = "0x6006699")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Quest()
      {
      }
    }

    [Token(Token = "0x200193E")]
    public class Owner
    {
      [Token(Token = "0x4005B55")]
      [FieldOffset(Offset = "0x8")]
      public string name;
      [Token(Token = "0x4005B56")]
      [FieldOffset(Offset = "0xC")]
      public string level;
      [Token(Token = "0x4005B57")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x4005B58")]
      [FieldOffset(Offset = "0x14")]
      public JSON_PlayerBuff player_buff;

      [Token(Token = "0x600669A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Owner()
      {
      }
    }
  }
}
