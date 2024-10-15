// Decompiled with JetBrains decompiler
// Type: SRPG.TowerRewardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D78")]
  public class TowerRewardItem
  {
    [Token(Token = "0x4007465")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007466")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x4007467")]
    [FieldOffset(Offset = "0x10")]
    public TowerRewardItem.RewardType type;
    [Token(Token = "0x4007468")]
    [FieldOffset(Offset = "0x11")]
    public bool visible;
    [Token(Token = "0x4007469")]
    [FieldOffset(Offset = "0x12")]
    public bool is_new;

    [Token(Token = "0x1700102A")]
    public bool IsDisableReward
    {
      [Token(Token = "0x600789B"), Address(RVA = "0x3A5A30", Offset = "0x3A4830", VA = "0x103A5A30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600789C")]
    [Address(RVA = "0x3A59C0", Offset = "0x3A47C0", VA = "0x103A59C0")]
    public void Deserialize(JSON_TowerRewardItem json)
    {
    }

    [Token(Token = "0x600789D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TowerRewardItem()
    {
    }

    [Token(Token = "0x2001D79")]
    public enum RewardType : byte
    {
      [Token(Token = "0x400746B")] Item,
      [Token(Token = "0x400746C")] Gold,
      [Token(Token = "0x400746D")] Coin,
      [Token(Token = "0x400746E")] ArenaCoin,
      [Token(Token = "0x400746F")] MultiCoin,
      [Token(Token = "0x4007470")] KakeraCoin,
      [Token(Token = "0x4007471")] Artifact,
    }
  }
}
