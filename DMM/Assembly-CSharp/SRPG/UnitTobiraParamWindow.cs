// Decompiled with JetBrains decompiler
// Type: SRPG.UnitTobiraParamWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D1E")]
  [AddComponentMenu("UI/UnitTobiraParamWindow")]
  public class UnitTobiraParamWindow : MonoBehaviour
  {
    [Token(Token = "0x400E0AE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TobiraTitleText;
    [Token(Token = "0x400E0AF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray TobiraIcons;
    [Token(Token = "0x400E0B0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject TobiraParamIconEnable;
    [Token(Token = "0x400E0B1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UnitTobiraParamLevel[] TobiraParamIconLevels;
    [Token(Token = "0x400E0B2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject TobiraParamIconDisable;
    [Token(Token = "0x400E0B3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StatusList Status;
    [Token(Token = "0x400E0B4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text AdditionalLevelCap;
    [Token(Token = "0x400E0B5")]
    [FieldOffset(Offset = "0x28")]
    [HeaderBar("▼扉LvをMaxにした時の恩恵")]
    [SerializeField]
    private Text TobiraMasterEffectText;
    [Token(Token = "0x400E0B6")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text TobiraMasterEffectDescText;
    [Token(Token = "0x400E0B7")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼扉が「未開放」時に表示するもの")]
    [SerializeField]
    private GameObject TobiraOpenButton;
    [Token(Token = "0x400E0B8")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text TobiraOpenButtonText;
    [Token(Token = "0x400E0B9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mLockedLayout;
    [Token(Token = "0x400E0BA")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mTobiraConditionsLayout;
    [Token(Token = "0x400E0BB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RectTransform mTobiraConditionsContent;
    [Token(Token = "0x400E0BC")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private UnitTobiraConditionsItem mTobiraConditionsTemplate;
    [Token(Token = "0x400E0BD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [HeaderBar("▼扉が「開放」時に表示するもの")]
    private GameObject TobiraLevelUpButton;
    [Token(Token = "0x400E0BE")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text TobiraLevelUpButtonText;
    [Token(Token = "0x400E0BF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mUnlockedLayout;
    [Token(Token = "0x400E0C0")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mTobiraMasterBonusLayout;
    [Token(Token = "0x400E0C1")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [HeaderBar("▼扉Lvが「Max」時に表示するもの")]
    private GameObject mTobiraMasterEbaleLayout;
    [Token(Token = "0x400E0C2")]
    [FieldOffset(Offset = "0x5C")]
    [HeaderBar("▼共鳴時減算表示用")]
    [SerializeField]
    private GameObject mDecreaseEffect;
    [Token(Token = "0x400E0C3")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Color mDecreaseTextColor;
    [Token(Token = "0x400E0C4")]
    [FieldOffset(Offset = "0x70")]
    private List<GameObject> mTobiraParameters;
    [Token(Token = "0x400E0C5")]
    [FieldOffset(Offset = "0x74")]
    private List<UnitTobiraConditionsItem> mTobiraConditions;

    [Token(Token = "0x600D226")]
    [Address(RVA = "0x9D2620", Offset = "0x9D1420", VA = "0x109D2620")]
    public void Refresh(UnitData unitData, TobiraData tobiraData, TobiraParam tobiraParam)
    {
    }

    [Token(Token = "0x600D227")]
    [Address(RVA = "0x9D30B0", Offset = "0x9D1EB0", VA = "0x109D30B0")]
    private void SetActiveConditionsItems(bool active)
    {
    }

    [Token(Token = "0x600D228")]
    [Address(RVA = "0x9D2240", Offset = "0x9D1040", VA = "0x109D2240")]
    private void CreateConditionsItems(UnitData unitData, TobiraConditionParam[] condition_params)
    {
    }

    [Token(Token = "0x600D229")]
    [Address(RVA = "0x9D2450", Offset = "0x9D1250", VA = "0x109D2450")]
    private void LockView(UnitData unitData, TobiraParam tobiraParam)
    {
    }

    [Token(Token = "0x600D22A")]
    [Address(RVA = "0x9D3800", Offset = "0x9D2600", VA = "0x109D3800")]
    private void UnlockView(UnitData unitData, TobiraData tobiraData)
    {
    }

    [Token(Token = "0x600D22B")]
    [Address(RVA = "0x9D31A0", Offset = "0x9D1FA0", VA = "0x109D31A0")]
    private static void SetHilightAnimationEnable(GameObject obj, bool isEnable)
    {
    }

    [Token(Token = "0x600D22C")]
    [Address(RVA = "0x9D3260", Offset = "0x9D2060", VA = "0x109D3260")]
    private void SetMasterBonusText(TobiraParam tobiraParam)
    {
    }

    [Token(Token = "0x600D22D")]
    [Address(RVA = "0x9D3AA0", Offset = "0x9D28A0", VA = "0x109D3AA0")]
    public UnitTobiraParamWindow()
    {
    }
  }
}
