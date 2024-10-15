// Decompiled with JetBrains decompiler
// Type: SRPG.EmbeddedTutorialMasterParams
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ACA")]
  public class EmbeddedTutorialMasterParams
  {
    [Token(Token = "0x6006E6F")]
    private static void SetParam<T>(object target, List<object> param, out T[] values)
    {
    }

    [Token(Token = "0x6006E70")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EmbeddedTutorialMasterParams()
    {
    }

    [Token(Token = "0x2001ACB")]
    [MessagePackObject(true)]
    public class JSON_EmbededMasterParam
    {
      [Token(Token = "0x400634A")]
      [FieldOffset(Offset = "0x8")]
      private Dictionary<string, Dictionary<string, string>> DataTable;
      [Token(Token = "0x400634B")]
      [FieldOffset(Offset = "0xC")]
      public JSON_UnitParam[] Unit;
      [Token(Token = "0x400634C")]
      [FieldOffset(Offset = "0x10")]
      public JSON_JobSetParam[] JobSet;
      [Token(Token = "0x400634D")]
      [FieldOffset(Offset = "0x14")]
      public JSON_JobParam[] Job;
      [Token(Token = "0x400634E")]
      [FieldOffset(Offset = "0x18")]
      public JSON_ArtifactParam[] Artifact;
      [Token(Token = "0x400634F")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_AbilityParam[] Ability;
      [Token(Token = "0x4006350")]
      [FieldOffset(Offset = "0x20")]
      public JSON_SkillParam[] Skill;
      [Token(Token = "0x4006351")]
      [FieldOffset(Offset = "0x24")]
      public JSON_BuffEffectParam[] Buff;
      [Token(Token = "0x4006352")]
      [FieldOffset(Offset = "0x28")]
      public JSON_TrickParam[] Trick;
      [Token(Token = "0x4006353")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_CondEffectParam[] Cond;
      [Token(Token = "0x4006354")]
      [FieldOffset(Offset = "0x30")]
      public JSON_GrowParam[] Grow;
      [Token(Token = "0x4006355")]
      [FieldOffset(Offset = "0x34")]
      public JSON_AIParam[] AI;
      [Token(Token = "0x4006356")]
      [FieldOffset(Offset = "0x38")]
      public JSON_ItemParam[] Item;
      [Token(Token = "0x4006357")]
      [FieldOffset(Offset = "0x3C")]
      public JSON_UnitJobOverwriteParam[] UnitJobOverwrite;
      [Token(Token = "0x4006358")]
      [FieldOffset(Offset = "0x40")]
      public JSON_WeaponParam[] Weapon;
      [Token(Token = "0x4006359")]
      [FieldOffset(Offset = "0x44")]
      public JSON_TipsParam[] Tips;
      [Token(Token = "0x400635A")]
      [FieldOffset(Offset = "0x48")]
      public JSON_GeoParam[] Geo;
      [Token(Token = "0x400635B")]
      [FieldOffset(Offset = "0x4C")]
      public JSON_FixParam[] Fix;
      [Token(Token = "0x400635C")]
      [FieldOffset(Offset = "0x50")]
      public JSON_UnlockParam[] Unlock;
      [Token(Token = "0x400635D")]
      [FieldOffset(Offset = "0x54")]
      public JSON_RarityParam[] Rarity;
      [Token(Token = "0x400635E")]
      [FieldOffset(Offset = "0x58")]
      public JSON_PlayerParam[] Player;
      [Token(Token = "0x400635F")]
      [FieldOffset(Offset = "0x5C")]
      public int[] UnitLvTbl;
      [Token(Token = "0x4006360")]
      [FieldOffset(Offset = "0x60")]
      public int[] PlayerLvTbl;

      [Token(Token = "0x6006E71")]
      public void Serialize<T>(List<object> param, out T[] values)
      {
      }

      [Token(Token = "0x6006E72")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_EmbededMasterParam()
      {
      }
    }

    [Token(Token = "0x2001ACC")]
    [MessagePackObject(true)]
    public class JSON_EmbededQuestParam
    {
      [Token(Token = "0x4006361")]
      [FieldOffset(Offset = "0x8")]
      public JSON_SectionParam[] worlds;
      [Token(Token = "0x4006362")]
      [FieldOffset(Offset = "0xC")]
      public JSON_ChapterParam[] areas;
      [Token(Token = "0x4006363")]
      [FieldOffset(Offset = "0x10")]
      public JSON_QuestParam[] quests;

      [Token(Token = "0x6006E73")]
      public void Serialize<T>(List<object> param, out T[] values)
      {
      }

      [Token(Token = "0x6006E74")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_EmbededQuestParam()
      {
      }
    }
  }
}
