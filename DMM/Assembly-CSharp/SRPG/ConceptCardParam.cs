// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A77")]
  [MessagePackObject(true)]
  public class ConceptCardParam
  {
    [Token(Token = "0x40061C2")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40061C3")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40061C4")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x40061C5")]
    [FieldOffset(Offset = "0x14")]
    public eCardType type;
    [Token(Token = "0x40061C6")]
    [FieldOffset(Offset = "0x18")]
    public string icon;
    [Token(Token = "0x40061C7")]
    [FieldOffset(Offset = "0x1C")]
    public int rare;
    [Token(Token = "0x40061C8")]
    [FieldOffset(Offset = "0x20")]
    public int lvcap;
    [Token(Token = "0x40061C9")]
    [FieldOffset(Offset = "0x24")]
    public int sell;
    [Token(Token = "0x40061CA")]
    [FieldOffset(Offset = "0x28")]
    public int coin_item;
    [Token(Token = "0x40061CB")]
    [FieldOffset(Offset = "0x2C")]
    public int en_cost;
    [Token(Token = "0x40061CC")]
    [FieldOffset(Offset = "0x30")]
    public int en_exp;
    [Token(Token = "0x40061CD")]
    [FieldOffset(Offset = "0x34")]
    public int en_trust;
    [Token(Token = "0x40061CE")]
    [FieldOffset(Offset = "0x38")]
    public string trust_reward;
    [Token(Token = "0x40061CF")]
    [FieldOffset(Offset = "0x3C")]
    public string first_get_unit;
    [Token(Token = "0x40061D0")]
    [FieldOffset(Offset = "0x40")]
    public bool is_override_lvcap;
    [Token(Token = "0x40061D1")]
    [FieldOffset(Offset = "0x44")]
    public ConceptCardEffectsParam[] effects;
    [Token(Token = "0x40061D2")]
    [FieldOffset(Offset = "0x48")]
    public bool not_sale;
    [Token(Token = "0x40061D3")]
    [FieldOffset(Offset = "0x4C")]
    public int birth_id;
    [Token(Token = "0x40061D4")]
    [FieldOffset(Offset = "0x50")]
    public string[] concept_card_groups;
    [Token(Token = "0x40061D5")]
    [FieldOffset(Offset = "0x54")]
    public string leader_skill;
    [Token(Token = "0x40061D6")]
    [FieldOffset(Offset = "0x58")]
    public GalleryVisibilityType gallery_view;
    [Token(Token = "0x40061D7")]
    [FieldOffset(Offset = "0x5C")]
    public bool is_other;
    [Token(Token = "0x40061D8")]
    [FieldOffset(Offset = "0x60")]
    public List<ConceptLimitUpItemParam> limit_up_items;
    [Token(Token = "0x40061D9")]
    [FieldOffset(Offset = "0x64")]
    public string bg_image;
    [Token(Token = "0x40061DA")]
    [FieldOffset(Offset = "0x68")]
    public string[] unit_images;
    [Token(Token = "0x40061DB")]
    [FieldOffset(Offset = "0x6C")]
    private int extra_rarity_pt_rare1;
    [Token(Token = "0x40061DC")]
    [FieldOffset(Offset = "0x70")]
    private int extra_rarity_pt_rare2;
    [Token(Token = "0x40061DD")]
    [FieldOffset(Offset = "0x74")]
    private int extra_rarity_pt_rare3;
    [Token(Token = "0x40061DE")]
    [FieldOffset(Offset = "0x78")]
    private int extra_rarity_pt_rare4;
    [Token(Token = "0x40061DF")]
    [FieldOffset(Offset = "0x7C")]
    private int extra_rarity_pt_rare5;
    [Token(Token = "0x40061E0")]
    [FieldOffset(Offset = "0x80")]
    private string extra_rarity_iname;

    [Token(Token = "0x17000BED")]
    public bool IsEnableAwake
    {
      [Token(Token = "0x6006CAA"), Address(RVA = "0x356980", Offset = "0x355780", VA = "0x10356980")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006CAB")]
    [Address(RVA = "0x356250", Offset = "0x355050", VA = "0x10356250")]
    public int GetExtraRarityPoint(int rare) => new int();

    [Token(Token = "0x17000BEE")]
    [IgnoreMember]
    public string ExtraRarityIname
    {
      [Token(Token = "0x6006CAC"), Address(RVA = "0x3197C0", Offset = "0x3185C0", VA = "0x103197C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BEF")]
    [IgnoreMember]
    public bool IsEnableExtraRarity
    {
      [Token(Token = "0x6006CAD"), Address(RVA = "0x3569C0", Offset = "0x3557C0", VA = "0x103569C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000BF0")]
    [IgnoreMember]
    public bool IsEnableExtraRarityMaterial
    {
      [Token(Token = "0x6006CAE"), Address(RVA = "0x356990", Offset = "0x355790", VA = "0x10356990")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000BF1")]
    public int AwakeCountCap
    {
      [Token(Token = "0x6006CAF"), Address(RVA = "0x356700", Offset = "0x355500", VA = "0x10356700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BF2")]
    public int AwakeLevelCap
    {
      [Token(Token = "0x6006CB0"), Address(RVA = "0x356790", Offset = "0x355590", VA = "0x10356790")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BF3")]
    [IgnoreMember]
    public OInt ExtraRarityLevelCap
    {
      [Token(Token = "0x6006CB1"), Address(RVA = "0x356870", Offset = "0x355670", VA = "0x10356870")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x6006CB2")]
    [Address(RVA = "0x355D70", Offset = "0x354B70", VA = "0x10355D70")]
    public bool Deserialize(JSON_ConceptCardParam json) => new bool();

    [Token(Token = "0x6006CB3")]
    [Address(RVA = "0x3564C0", Offset = "0x3552C0", VA = "0x103564C0")]
    public static void GetSkillStatus(
      string statusup_skill,
      int awakeLvCap,
      int lv,
      ref BaseStatus add,
      ref BaseStatus scale)
    {
    }

    [Token(Token = "0x6006CB4")]
    [Address(RVA = "0x356450", Offset = "0x355250", VA = "0x10356450")]
    public static void GetSkillAllStatus(
      string statusup_skill,
      int awakeLvCap,
      int lv,
      ref BaseStatus add,
      ref BaseStatus scale)
    {
    }

    [Token(Token = "0x6006CB5")]
    [Address(RVA = "0x356560", Offset = "0x355360", VA = "0x10356560")]
    public bool IsExistAddCardSkillBuffAwake() => new bool();

    [Token(Token = "0x6006CB6")]
    [Address(RVA = "0x356600", Offset = "0x355400", VA = "0x10356600")]
    public bool IsExistAddCardSkillBuffLvMax() => new bool();

    [Token(Token = "0x6006CB7")]
    [Address(RVA = "0x3562B0", Offset = "0x3550B0", VA = "0x103562B0")]
    public string GetLocalizedTextFlavor() => (string) null;

    [Token(Token = "0x6006CB8")]
    [Address(RVA = "0x3563E0", Offset = "0x3551E0", VA = "0x103563E0")]
    public string GetLocalizedTextMessage() => (string) null;

    [Token(Token = "0x6006CB9")]
    [Address(RVA = "0x356170", Offset = "0x354F70", VA = "0x10356170")]
    public ConceptLimitUpItemParam GetConcepLimitUpItemParam(string item_id)
    {
      return (ConceptLimitUpItemParam) null;
    }

    [Token(Token = "0x6006CBA")]
    [Address(RVA = "0x356540", Offset = "0x355340", VA = "0x10356540")]
    public bool IsComposite() => new bool();

    [Token(Token = "0x6006CBB")]
    [Address(RVA = "0x356320", Offset = "0x355120", VA = "0x10356320")]
    public string GetLocalizedTextKeyword() => (string) null;

    [Token(Token = "0x6006CBC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardParam()
    {
    }
  }
}
