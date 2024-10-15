// Decompiled with JetBrains decompiler
// Type: SRPG.UnitIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C35")]
  [AddComponentMenu("UI/UnitIcon")]
  public class UnitIcon : BaseIcon
  {
    [Token(Token = "0x400DADF")]
    private const string TooltipPath = "UI/UnitTooltip_1";
    [Token(Token = "0x400DAE0")]
    [FieldOffset(Offset = "0xC")]
    [Space(10f)]
    public GameParameter.UnitInstanceTypes InstanceType;
    [Token(Token = "0x400DAE1")]
    [FieldOffset(Offset = "0x10")]
    public int InstanceIndex;
    [Token(Token = "0x400DAE2")]
    [FieldOffset(Offset = "0x14")]
    public bool Tooltip;
    [Token(Token = "0x400DAE3")]
    [FieldOffset(Offset = "0x18")]
    [Space(10f)]
    public RawImage Icon;
    [Token(Token = "0x400DAE4")]
    [FieldOffset(Offset = "0x1C")]
    public Image Frame;
    [Token(Token = "0x400DAE5")]
    [FieldOffset(Offset = "0x20")]
    public Image Rarity;
    [Token(Token = "0x400DAE6")]
    [FieldOffset(Offset = "0x24")]
    public Text Level;
    [Token(Token = "0x400DAE7")]
    [FieldOffset(Offset = "0x28")]
    public Image Element;
    [Token(Token = "0x400DAE8")]
    [FieldOffset(Offset = "0x2C")]
    public RawImage Job;
    [Token(Token = "0x400DAE9")]
    [FieldOffset(Offset = "0x30")]
    public GameObject LvParent;
    [Token(Token = "0x400DAEA")]
    [FieldOffset(Offset = "0x34")]
    public SortBadge SortBadge;
    [Token(Token = "0x400DAEB")]
    [FieldOffset(Offset = "0x38")]
    public bool AllowJobChange;
    [Token(Token = "0x400DAEC")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject ResonanceObj;
    [Token(Token = "0x400DAED")]
    [FieldOffset(Offset = "0x40")]
    public Text ResonanceLevel;
    [Token(Token = "0x400DAEE")]
    [FieldOffset(Offset = "0x44")]
    public GameObject HaveIcon;
    [Token(Token = "0x400DAEF")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsLvActive;

    [Token(Token = "0x17001B19")]
    public override bool HasTooltip
    {
      [Token(Token = "0x600CCC1"), Address(RVA = "0x9799F0", Offset = "0x9787F0", VA = "0x109799F0", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CCC2")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600CCC3")]
    [Address(RVA = "0x44DD90", Offset = "0x44CB90", VA = "0x1044DD90")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600CCC4")]
    [Address(RVA = "0x978C40", Offset = "0x977A40", VA = "0x10978C40")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600CCC5")]
    [Address(RVA = "0x978BE0", Offset = "0x9779E0", VA = "0x10978BE0", Slot = "13")]
    protected virtual UnitData GetInstanceData() => (UnitData) null;

    [Token(Token = "0x600CCC6")]
    [Address(RVA = "0x978EB0", Offset = "0x977CB0", VA = "0x10978EB0", Slot = "9")]
    protected override void ShowTooltip(Vector2 screen)
    {
    }

    [Token(Token = "0x600CCC7")]
    [Address(RVA = "0x979060", Offset = "0x977E60", VA = "0x10979060", Slot = "12")]
    public override void UpdateValue()
    {
    }

    [Token(Token = "0x600CCC8")]
    [Address(RVA = "0x978D10", Offset = "0x977B10", VA = "0x10978D10")]
    public void SetSortValue(GameUtility.UnitSortModes mode, int value, bool isLevelActive = true)
    {
    }

    [Token(Token = "0x600CCC9")]
    [Address(RVA = "0x978B60", Offset = "0x977960", VA = "0x10978B60")]
    public void ClearSortValue()
    {
    }

    [Token(Token = "0x600CCCA")]
    [Address(RVA = "0x978FE0", Offset = "0x977DE0", VA = "0x10978FE0")]
    public void UpdatePartyWindow()
    {
    }

    [Token(Token = "0x600CCCB")]
    [Address(RVA = "0x978980", Offset = "0x977780", VA = "0x10978980")]
    public UnitIcon()
    {
    }
  }
}
