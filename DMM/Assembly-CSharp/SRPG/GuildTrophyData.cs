// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrophyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D86")]
  public class GuildTrophyData : TrophyBase
  {
    [Token(Token = "0x40074D9")]
    [FieldOffset(Offset = "0x18")]
    private bool mHasRewards;

    [Token(Token = "0x17001045")]
    public bool HasRewards
    {
      [Token(Token = "0x60078C5"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60078C6")]
    [Address(RVA = "0x3A1540", Offset = "0x3A0340", VA = "0x103A1540")]
    public void OverwriteGuildTrophyProgress(
      JSON_TrophyProgress[] trophyProgressList,
      bool is_notify_send = true)
    {
    }

    [Token(Token = "0x60078C7")]
    [Address(RVA = "0x3A17A0", Offset = "0x3A05A0", VA = "0x103A17A0")]
    public void UpdateHasRewards()
    {
    }

    [Token(Token = "0x60078C8")]
    [Address(RVA = "0x3A18B0", Offset = "0x3A06B0", VA = "0x103A18B0")]
    public GuildTrophyData()
    {
    }
  }
}
