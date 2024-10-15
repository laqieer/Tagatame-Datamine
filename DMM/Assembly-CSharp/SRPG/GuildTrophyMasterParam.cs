// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrophyMasterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D87")]
  public class GuildTrophyMasterParam
  {
    [Token(Token = "0x60078C9")]
    [Address(RVA = "0x3A18C0", Offset = "0x3A06C0", VA = "0x103A18C0")]
    public static void Deserialize(
      ref GuildTrophyParam[] refTrophy,
      ref TrophyCategoryParam[] refTrophyCategory,
      ref Dictionary<string, GuildTrophyParam> refTrophyInameDict,
      JSON_TrophyParam[] json_Trophy,
      JSON_TrophyCategoryParam[] json_TrophyCategory)
    {
    }

    [Token(Token = "0x60078CA")]
    [Address(RVA = "0x3A1950", Offset = "0x3A0750", VA = "0x103A1950")]
    private static void Deserialize(
      ref TrophyCategoryParam[] refTrophyCategory,
      ref Dictionary<int, TrophyCategoryParam> refTrophyCategoryDict,
      JSON_TrophyCategoryParam[] json_TrophyCategory)
    {
    }

    [Token(Token = "0x60078CB")]
    [Address(RVA = "0x3A1C40", Offset = "0x3A0A40", VA = "0x103A1C40")]
    private static void Deserialize(
      ref GuildTrophyParam[] refTrophy,
      ref Dictionary<string, GuildTrophyParam> refTrophyInameDict,
      JSON_TrophyParam[] json_Trophy,
      Dictionary<int, TrophyCategoryParam> trophy_category_dict)
    {
    }

    [Token(Token = "0x60078CC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildTrophyMasterParam()
    {
    }
  }
}
