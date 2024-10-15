// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalReplaceWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002291")]
  [AddComponentMenu("UI/Crystal/Wondow/CrystalReplaceWindow")]
  [FlowNode.Pin(902, "画面クリックを不許可", FlowNode.PinTypes.Output, 902)]
  [FlowNode.Pin(901, "画面クリックを許可", FlowNode.PinTypes.Output, 901)]
  [FlowNode.Pin(10, "絞り込み", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(101, "交換実行", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(2, "更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "お気に入り更新", FlowNode.PinTypes.Input, 3)]
  public class CrystalReplaceWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x4009985")]
    public const string UnitToolTip = "UnitToolTip";
    [Token(Token = "0x4009986")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x4009987")]
    private const int PIN_IN_REFRESH = 2;
    [Token(Token = "0x4009988")]
    private const int PIN_IN_FAVORITE_UPDATE = 3;
    [Token(Token = "0x4009989")]
    private const int PIN_IN_FILTER = 10;
    [Token(Token = "0x400998A")]
    private const int PIN_OUT_REPLACE_EXECUTE = 101;
    [Token(Token = "0x400998B")]
    private const int PIN_OUT_BLOCK_RAYCAST_ON = 901;
    [Token(Token = "0x400998C")]
    private const int PIN_OUT_BLOCK_RAYCAST_OFF = 902;
    [Token(Token = "0x400998D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400998E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentExhibit mContentExhibit;
    [Token(Token = "0x400998F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CrystalReplaceTabFilter[] mTabList;
    [Token(Token = "0x4009990")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle mEquipOnly;
    [Token(Token = "0x4009991")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ImageArray mFilterBtn;
    [Token(Token = "0x4009992")]
    [FieldOffset(Offset = "0x20")]
    private UnitData mBaseUnit;
    [Token(Token = "0x4009993")]
    [FieldOffset(Offset = "0x24")]
    private UnitData mTargetUnit;
    [Token(Token = "0x4009994")]
    [FieldOffset(Offset = "0x28")]
    private CrystalReplaceContentModel mBaseModel;
    [Token(Token = "0x4009995")]
    [FieldOffset(Offset = "0x2C")]
    private List<CrystalReplaceContentModel> mAllContentModels;
    [Token(Token = "0x4009996")]
    [FieldOffset(Offset = "0x30")]
    private List<CrystalReplaceContentModel> mTargetContentModels;
    [Token(Token = "0x4009997")]
    [FieldOffset(Offset = "0x34")]
    private CrystalReplaceSort SortData;
    [Token(Token = "0x4009998")]
    [FieldOffset(Offset = "0x38")]
    public bool IsNeedFilterUpdate;
    [Token(Token = "0x4009999")]
    [FieldOffset(Offset = "0x0")]
    private static CrystalReplaceWindow mInstance;

    [Token(Token = "0x170014CC")]
    public static CrystalReplaceWindow Instance
    {
      [Token(Token = "0x60093FA"), Address(RVA = "0x570010", Offset = "0x56EE10", VA = "0x10570010")] get
      {
        return (CrystalReplaceWindow) null;
      }
    }

    [Token(Token = "0x60093FB")]
    [Address(RVA = "0x56FBD0", Offset = "0x56E9D0", VA = "0x1056FBD0")]
    private void Start()
    {
    }

    [Token(Token = "0x60093FC")]
    [Address(RVA = "0x56F620", Offset = "0x56E420", VA = "0x1056F620")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60093FD")]
    [Address(RVA = "0x56EA70", Offset = "0x56D870", VA = "0x1056EA70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60093FE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60093FF")]
    [Address(RVA = "0x56F240", Offset = "0x56E040", VA = "0x1056F240")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6009400")]
    [Address(RVA = "0x56FAA0", Offset = "0x56E8A0", VA = "0x1056FAA0")]
    private void Refresh(bool is_base_refresh = false)
    {
    }

    [Token(Token = "0x6009401")]
    [Address(RVA = "0x56ECC0", Offset = "0x56DAC0", VA = "0x1056ECC0")]
    private void InitializeBaseUnit()
    {
    }

    [Token(Token = "0x6009402")]
    [Address(RVA = "0x56EE70", Offset = "0x56DC70", VA = "0x1056EE70")]
    private void InitializeUnitList()
    {
    }

    [Token(Token = "0x6009403")]
    [Address(RVA = "0x56FC10", Offset = "0x56EA10", VA = "0x1056FC10")]
    private void TabAndEquipCheck(CrystalReplaceTabFilter tab = null)
    {
    }

    [Token(Token = "0x6009404")]
    [Address(RVA = "0x56EBD0", Offset = "0x56D9D0", VA = "0x1056EBD0")]
    private void Filter()
    {
    }

    [Token(Token = "0x6009405")]
    [Address(RVA = "0x56F970", Offset = "0x56E770", VA = "0x1056F970")]
    private void OnSetupCrsytalReplaceTarget(ContentNode node, CrystalReplaceContentModel model)
    {
    }

    [Token(Token = "0x6009406")]
    [Address(RVA = "0x56F770", Offset = "0x56E570", VA = "0x1056F770")]
    private void OnSelectlReplaceTarget(CrystalReplaceContentModel model)
    {
    }

    [Token(Token = "0x6009407")]
    [Address(RVA = "0x56F4A0", Offset = "0x56E2A0", VA = "0x1056F4A0")]
    private bool IsCrystalAllreplace(UnitData unit, UnitData target_unit) => new bool();

    [Token(Token = "0x6009408")]
    [Address(RVA = "0x56EB20", Offset = "0x56D920", VA = "0x1056EB20")]
    private void ExecuteReplaceReqest()
    {
    }

    [Token(Token = "0x6009409")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalReplaceWindow()
    {
    }
  }
}
