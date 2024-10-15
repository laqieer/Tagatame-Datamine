// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerLevelUpInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027F9")]
  public class PlayerLevelUpInfo
  {
    [Token(Token = "0x400BE41")]
    [FieldOffset(Offset = "0x8")]
    public int LevelPrev;
    [Token(Token = "0x400BE42")]
    [FieldOffset(Offset = "0xC")]
    public int LevelNext;
    [Token(Token = "0x400BE43")]
    [FieldOffset(Offset = "0x10")]
    public int StaminaNext;
    [Token(Token = "0x400BE44")]
    [FieldOffset(Offset = "0x14")]
    public int StaminaMaxPrev;
    [Token(Token = "0x400BE45")]
    [FieldOffset(Offset = "0x18")]
    public int StaminaMaxNext;
    [Token(Token = "0x400BE46")]
    [FieldOffset(Offset = "0x1C")]
    public int MaxFriendNumPrev;
    [Token(Token = "0x400BE47")]
    [FieldOffset(Offset = "0x20")]
    public int MaxFriendNumNext;
    [Token(Token = "0x400BE48")]
    [FieldOffset(Offset = "0x24")]
    public string[] UnlockInfo;

    [Token(Token = "0x600B47A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PlayerLevelUpInfo()
    {
    }
  }
}
