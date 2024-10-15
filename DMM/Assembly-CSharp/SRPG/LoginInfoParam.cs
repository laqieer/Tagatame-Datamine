// Decompiled with JetBrains decompiler
// Type: SRPG.LoginInfoParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BD0")]
  [Serializable]
  public class LoginInfoParam
  {
    [Token(Token = "0x4006AA3")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006AA4")]
    [FieldOffset(Offset = "0xC")]
    public string path;
    [Token(Token = "0x4006AA5")]
    [FieldOffset(Offset = "0x10")]
    public LoginInfoParam.SelectScene scene;
    [Token(Token = "0x4006AA6")]
    [FieldOffset(Offset = "0x18")]
    public long begin_at;
    [Token(Token = "0x4006AA7")]
    [FieldOffset(Offset = "0x20")]
    public long end_at;
    [Token(Token = "0x4006AA8")]
    [FieldOffset(Offset = "0x28")]
    public LoginInfoParam.DispConditions conditions;
    [Token(Token = "0x4006AA9")]
    [FieldOffset(Offset = "0x2C")]
    public int conditions_value;
    [Token(Token = "0x4006AAA")]
    [FieldOffset(Offset = "0x30")]
    public int priority;
    [Token(Token = "0x4006AAB")]
    [FieldOffset(Offset = "0x34")]
    public int draw_count;
    [Token(Token = "0x4006AAC")]
    [FieldOffset(Offset = "0x38")]
    public bool movie_compel;
    [Token(Token = "0x4006AAD")]
    [FieldOffset(Offset = "0x3C")]
    public string movie;
    [Token(Token = "0x4006AAE")]
    [FieldOffset(Offset = "0x40")]
    public string url;

    [Token(Token = "0x60072E4")]
    [Address(RVA = "0x37AE40", Offset = "0x379C40", VA = "0x1037AE40")]
    public bool Deserialize(JSON_LoginInfoParam json) => new bool();

    [Token(Token = "0x60072E5")]
    [Address(RVA = "0x37AFE0", Offset = "0x379DE0", VA = "0x1037AFE0")]
    public bool IsDisplayable(DateTime server_time, int player_level, bool is_beginner)
    {
      return new bool();
    }

    [Token(Token = "0x60072E6")]
    [Address(RVA = "0x37ADE0", Offset = "0x379BE0", VA = "0x1037ADE0")]
    private bool CheckConditions(int player_level, bool is_beginner) => new bool();

    [Token(Token = "0x60072E7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LoginInfoParam()
    {
    }

    [Token(Token = "0x2001BD1")]
    public enum SelectScene : byte
    {
      [Token(Token = "0x4006AB0")] None,
      [Token(Token = "0x4006AB1")] Gacha,
      [Token(Token = "0x4006AB2")] LimitedShop,
      [Token(Token = "0x4006AB3")] EventQuest,
      [Token(Token = "0x4006AB4")] TowerQuest,
      [Token(Token = "0x4006AB5")] BuyShop,
    }

    [Token(Token = "0x2001BD2")]
    public enum DispConditions
    {
      [Token(Token = "0x4006AB7")] None,
      [Token(Token = "0x4006AB8")] PlayerLvMore,
      [Token(Token = "0x4006AB9")] PlayerLvLess,
      [Token(Token = "0x4006ABA")] Beginner,
      [Token(Token = "0x4006ABB")] NotBeginner,
    }
  }
}
