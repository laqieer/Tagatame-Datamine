// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrophyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D8A")]
  public class GuildTrophyParam : TrophyParam
  {
    [Token(Token = "0x60078D1")]
    [Address(RVA = "0x3A2DA0", Offset = "0x3A1BA0", VA = "0x103A2DA0", Slot = "4")]
    public override void SetTrophyObjectives(
      ref TrophyObjective[] trophy_objectives,
      JSON_TrophyParam json,
      int objective_length)
    {
    }

    [Token(Token = "0x60078D2")]
    [Address(RVA = "0x3A2D40", Offset = "0x3A1B40", VA = "0x103A2D40", Slot = "5")]
    public override TrophyState GetTrophyCounter() => (TrophyState) null;

    [Token(Token = "0x60078D3")]
    [Address(RVA = "0x3A2EF0", Offset = "0x3A1CF0", VA = "0x103A2EF0")]
    public GuildTrophyParam()
    {
    }
  }
}
