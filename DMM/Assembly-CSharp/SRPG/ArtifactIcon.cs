// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FFE")]
  [AddComponentMenu("UI/ArtifactIcon")]
  public class ArtifactIcon : BaseIcon
  {
    [Token(Token = "0x4008850")]
    [FieldOffset(Offset = "0xC")]
    public RawImage Icon;
    [Token(Token = "0x4008851")]
    [FieldOffset(Offset = "0x10")]
    public Image Rarity;
    [Token(Token = "0x4008852")]
    [FieldOffset(Offset = "0x14")]
    public Image RarityMax;
    [Token(Token = "0x4008853")]
    [FieldOffset(Offset = "0x18")]
    public Text RarityText;
    [Token(Token = "0x4008854")]
    [FieldOffset(Offset = "0x1C")]
    public Text RarityMaxText;
    [Token(Token = "0x4008855")]
    [FieldOffset(Offset = "0x20")]
    public Image Frame;
    [Token(Token = "0x4008856")]
    [FieldOffset(Offset = "0x24")]
    public Text Lv;
    [Token(Token = "0x4008857")]
    [FieldOffset(Offset = "0x28")]
    public Text LvCap;
    [Token(Token = "0x4008858")]
    [FieldOffset(Offset = "0x2C")]
    public Text PreLvCap;
    [Token(Token = "0x4008859")]
    [FieldOffset(Offset = "0x30")]
    public Slider LvGauge;
    [Token(Token = "0x400885A")]
    [FieldOffset(Offset = "0x34")]
    public Slider ExpGauge;
    [Token(Token = "0x400885B")]
    [FieldOffset(Offset = "0x38")]
    public Slider PieceGauge;
    [Token(Token = "0x400885C")]
    [FieldOffset(Offset = "0x3C")]
    public Image Category;
    [Token(Token = "0x400885D")]
    [FieldOffset(Offset = "0x40")]
    public GameObject Owner;
    [Token(Token = "0x400885E")]
    [FieldOffset(Offset = "0x44")]
    public Image OwnerIcon;
    [Token(Token = "0x400885F")]
    [FieldOffset(Offset = "0x48")]
    public bool IsDispOwner_Arena;
    [Token(Token = "0x4008860")]
    [FieldOffset(Offset = "0x49")]
    public bool IsDispOwner_Support;
    [Token(Token = "0x4008861")]
    [FieldOffset(Offset = "0x4A")]
    public bool IsDispOwner_GvG;
    [Token(Token = "0x4008862")]
    [FieldOffset(Offset = "0x4B")]
    public bool IsDispOwner_LeagueMatch;
    [Token(Token = "0x4008863")]
    [FieldOffset(Offset = "0x4C")]
    public Text DecCost;
    [Token(Token = "0x4008864")]
    [FieldOffset(Offset = "0x50")]
    public Text DecKakeraNum;
    [Token(Token = "0x4008865")]
    [FieldOffset(Offset = "0x54")]
    public Text TransmuteCost;
    [Token(Token = "0x4008866")]
    [FieldOffset(Offset = "0x58")]
    public GameObject NotRarityUp;
    [Token(Token = "0x4008867")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject CanRarityUp;
    [Token(Token = "0x4008868")]
    [FieldOffset(Offset = "0x60")]
    public bool ForceMask;
    [Token(Token = "0x4008869")]
    [FieldOffset(Offset = "0x61")]
    public bool EquipForceMask;
    [Token(Token = "0x400886A")]
    [FieldOffset(Offset = "0x62")]
    public bool SpecialDisplayForceItem;
    [Token(Token = "0x400886B")]
    [FieldOffset(Offset = "0x64")]
    public ArtifactIcon.InstanceTypes InstanceType;
    [Token(Token = "0x400886C")]
    [FieldOffset(Offset = "0x68")]
    public int DeriveTriggerIndex;
    [Token(Token = "0x400886D")]
    [FieldOffset(Offset = "0x6C")]
    [NonSerialized]
    public GameObject IndexBadge;
    [Token(Token = "0x400886E")]
    [FieldOffset(Offset = "0x70")]
    private int mLastLv;
    [Token(Token = "0x400886F")]
    [FieldOffset(Offset = "0x74")]
    private int mLastLvCap;
    [Token(Token = "0x4008870")]
    [FieldOffset(Offset = "0x78")]
    private int mLastExpNum;
    [Token(Token = "0x4008871")]
    [FieldOffset(Offset = "0x7C")]
    public GameObject RarityUp;
    [Token(Token = "0x4008872")]
    [FieldOffset(Offset = "0x80")]
    public GameObject CanCreate;
    [Token(Token = "0x4008873")]
    [FieldOffset(Offset = "0x84")]
    public Image RarityUpBack;
    [Token(Token = "0x4008874")]
    [FieldOffset(Offset = "0x88")]
    public Image CanCreateBack;
    [Token(Token = "0x4008875")]
    [FieldOffset(Offset = "0x8C")]
    public Image CanCreateGauge;
    [Token(Token = "0x4008876")]
    [FieldOffset(Offset = "0x90")]
    public Image DefaultGauge;
    [Token(Token = "0x4008877")]
    [FieldOffset(Offset = "0x94")]
    public Image DefaultBack;
    [Token(Token = "0x4008878")]
    [FieldOffset(Offset = "0x98")]
    public Text RarityUpCost;
    [Token(Token = "0x4008879")]
    [FieldOffset(Offset = "0x9C")]
    public Text PieceNum;
    [Token(Token = "0x400887A")]
    [FieldOffset(Offset = "0xA0")]
    public Image[] NotCreateGrayIcon;
    [Token(Token = "0x400887B")]
    [FieldOffset(Offset = "0xA4")]
    public RawImage[] NotCreateGrayRawIcon;
    [Token(Token = "0x400887C")]
    [FieldOffset(Offset = "0xA8")]
    public GameObject Favorite;
    [Token(Token = "0x400887D")]
    [FieldOffset(Offset = "0xAC")]
    public GameObject LockMask;
    [Token(Token = "0x400887E")]
    [FieldOffset(Offset = "0xB0")]
    public GameObject EquipLockMask;
    [Token(Token = "0x400887F")]
    [FieldOffset(Offset = "0xB4")]
    public GameObject SpecialDisplayItem;
    [Token(Token = "0x4008880")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private bool mIsIncludeOverWrite;

    [Token(Token = "0x6008427")]
    [Address(RVA = "0x44DD90", Offset = "0x44CB90", VA = "0x1044DD90")]
    private void Start()
    {
    }

    [Token(Token = "0x6008428")]
    [Address(RVA = "0x44D9A0", Offset = "0x44C7A0", VA = "0x1044D9A0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6008429")]
    [Address(RVA = "0x44DDB0", Offset = "0x44CBB0", VA = "0x1044DDB0", Slot = "12")]
    public override void UpdateValue()
    {
    }

    [Token(Token = "0x600842A")]
    [Address(RVA = "0x44DA70", Offset = "0x44C870", VA = "0x1044DA70")]
    private bool SetOwnerIcon(GameManager gm, ArtifactData data) => new bool();

    [Token(Token = "0x600842B")]
    [Address(RVA = "0x44F7E0", Offset = "0x44E5E0", VA = "0x1044F7E0")]
    public ArtifactIcon()
    {
    }

    [Token(Token = "0x2001FFF")]
    public enum InstanceTypes
    {
      [Token(Token = "0x4008882")] ArtifactData,
      [Token(Token = "0x4008883")] ArtifactParam,
      [Token(Token = "0x4008884")] SkillAbilityDeriveParam,
      [Token(Token = "0x4008885")] ArtifactDataOrParam,
    }
  }
}
