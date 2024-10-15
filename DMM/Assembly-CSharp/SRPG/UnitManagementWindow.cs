// Decompiled with JetBrains decompiler
// Type: SRPG.UnitManagementWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CB3")]
  [FlowNode.Pin(15, "真理開眼ウィンドウへ戻る", FlowNode.PinTypes.Output, 150)]
  [FlowNode.Pin(14, "錬成画面へ戻る", FlowNode.PinTypes.Output, 140)]
  [FlowNode.Pin(13, "進化ウィンドウへ戻る", FlowNode.PinTypes.Output, 130)]
  [FlowNode.Pin(12, "限界突破画面へ戻る", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(11, "キャラクタークエスト画面へ戻る", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(10, "強化画面へ戻る", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(2, "ユニット選択へ", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(1, "初期化開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "ユニット詳細を表示", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(500, "ユニット強化", FlowNode.PinTypes.Input, 500)]
  [AddComponentMenu("UI/UnitManagementWindow")]
  [FlowNode.Pin(510, "ユニット選択へ戻る", FlowNode.PinTypes.Output, 510)]
  public class UnitManagementWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DE05")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private string PreviewParentID;
    [Token(Token = "0x400DE06")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string PreviewBaseID;
    [Token(Token = "0x400DE07")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private string UnitDetailPreviewPosID;
    [Token(Token = "0x400DE08")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string UnitDetailPreviewBasePosID;
    [Token(Token = "0x400DE09")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string UnitTobiraPreviewPosID;
    [Token(Token = "0x400DE0A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string UnitTobiraPreviewBasePosID;
    [Token(Token = "0x400DE0B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public string PATH_UNIT_LIST_WINDOW;
    [Token(Token = "0x400DE0C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string PATH_UNIT_EQUIPMENT_WINDOW;
    [Token(Token = "0x400DE0D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public string PATH_UNIT_KAKERA_WINDOW;
    [Token(Token = "0x400DE0E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string PATH_UNIT_INVENTORY_WINDOW;
    [Token(Token = "0x400DE0F")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public string PATH_TOBIRA_INVENTORY_WINDOW;
    [Token(Token = "0x400DE10")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string PATH_RUNE_INVENTORY_WINDOW;
    [Token(Token = "0x400DE11")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject TobiraObject;
    [Token(Token = "0x400DE12")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject RuneObject;
    [Token(Token = "0x400DE13")]
    [FieldOffset(Offset = "0x44")]
    private bool mInitialize;
    [Token(Token = "0x400DE14")]
    [FieldOffset(Offset = "0x48")]
    private UnitListWindow mUnitListWindow;
    [Token(Token = "0x400DE15")]
    [FieldOffset(Offset = "0x4C")]
    private UnitEnhanceV3 mUEMain;
    [Token(Token = "0x400DE16")]
    [FieldOffset(Offset = "0x50")]
    private UnitEquipmentWindow mEquipWindow;
    [Token(Token = "0x400DE17")]
    [FieldOffset(Offset = "0x54")]
    private UnitKakeraWindow mKakeraWindow;
    [Token(Token = "0x400DE18")]
    [FieldOffset(Offset = "0x58")]
    private LoadRequest mReqAbilityDetail;
    [Token(Token = "0x400DE19")]
    [FieldOffset(Offset = "0x5C")]
    private LoadRequest mUnitInventoryWindowLoadRequest;
    [Token(Token = "0x400DE1A")]
    [FieldOffset(Offset = "0x0")]
    private static UnitListRootWindow.Tab mCurrentTab;
    [Token(Token = "0x400DE1B")]
    [FieldOffset(Offset = "0x60")]
    private Vector2 mCurrentTabAnchorePos;
    [Token(Token = "0x400DE1C")]
    [FieldOffset(Offset = "0x68")]
    private long mCurrentUnit;
    [Token(Token = "0x400DE1D")]
    [FieldOffset(Offset = "0x70")]
    private Transform mUnitModelPreviewParent;
    [Token(Token = "0x400DE1E")]
    [FieldOffset(Offset = "0x74")]
    private Transform mUnitModelPreviewBase;
    [Token(Token = "0x400DE1F")]
    [FieldOffset(Offset = "0x78")]
    private QuestDropParam mQuestDropParam;
    [Token(Token = "0x400DE20")]
    [FieldOffset(Offset = "0x4")]
    private static string mNameSearchText;
    [Token(Token = "0x400DE21")]
    [FieldOffset(Offset = "0x8")]
    private static UnitManagementWindow instance;

    [Token(Token = "0x17001B47")]
    public static UnitManagementWindow Instance
    {
      [Token(Token = "0x600CF97"), Address(RVA = "0x9AFC30", Offset = "0x9AEA30", VA = "0x109AFC30")] get
      {
        return (UnitManagementWindow) null;
      }
    }

    [Token(Token = "0x17001B48")]
    public Transform UnitModelPreviewParent
    {
      [Token(Token = "0x600CF98"), Address(RVA = "0x288AD0", Offset = "0x2878D0", VA = "0x10288AD0")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17001B49")]
    public Transform UnitModelPreviewBase
    {
      [Token(Token = "0x600CF99"), Address(RVA = "0x349360", Offset = "0x348160", VA = "0x10349360")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x600CF9A")]
    [Address(RVA = "0x9AE8A0", Offset = "0x9AD6A0", VA = "0x109AE8A0")]
    public UnitListRootWindow.Tab GetCurrentTab() => new UnitListRootWindow.Tab();

    [Token(Token = "0x600CF9B")]
    [Address(RVA = "0x9AF910", Offset = "0x9AE710", VA = "0x109AF910")]
    public void SetCurrentTab(UnitListRootWindow.Tab tab)
    {
    }

    [Token(Token = "0x600CF9C")]
    [Address(RVA = "0x9AE2B0", Offset = "0x9AD0B0", VA = "0x109AE2B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600CF9D")]
    [Address(RVA = "0x9AF9B0", Offset = "0x9AE7B0", VA = "0x109AF9B0")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600CF9E")]
    [Address(RVA = "0x9AF940", Offset = "0x9AE740", VA = "0x109AF940")]
    private IEnumerator SetupByRestorePoint(RestorePoints restore_point) => (IEnumerator) null;

    [Token(Token = "0x600CF9F")]
    [Address(RVA = "0x9AE610", Offset = "0x9AD410", VA = "0x109AE610")]
    private IEnumerator CreateUnitInventoryWindow() => (IEnumerator) null;

    [Token(Token = "0x600CFA0")]
    [Address(RVA = "0x9AED20", Offset = "0x9ADB20", VA = "0x109AED20")]
    private IEnumerator InitUnitInventoryWindow(UnitListRootWindow window, long unique_id)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CFA1")]
    [Address(RVA = "0x9AEFA0", Offset = "0x9ADDA0", VA = "0x109AEFA0")]
    private IEnumerator InitializeUnitDetail(UnitData unitData, bool muteVoice)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CFA2")]
    [Address(RVA = "0x9AF170", Offset = "0x9ADF70", VA = "0x109AF170")]
    private IEnumerator InitializeUnitKyouka() => (IEnumerator) null;

    [Token(Token = "0x600CFA3")]
    [Address(RVA = "0x9AEEC0", Offset = "0x9ADCC0", VA = "0x109AEEC0")]
    private IEnumerator InitializeUnitCharacterQuest() => (IEnumerator) null;

    [Token(Token = "0x600CFA4")]
    [Address(RVA = "0x9AF100", Offset = "0x9ADF00", VA = "0x109AF100")]
    private IEnumerator InitializeUnitKakera() => (IEnumerator) null;

    [Token(Token = "0x600CFA5")]
    [Address(RVA = "0x9AF090", Offset = "0x9ADE90", VA = "0x109AF090")]
    private IEnumerator InitializeUnitEvolution() => (IEnumerator) null;

    [Token(Token = "0x600CFA6")]
    [Address(RVA = "0x9AF2C0", Offset = "0x9AE0C0", VA = "0x109AF2C0")]
    private IEnumerator InitializeUnitUnlock() => (IEnumerator) null;

    [Token(Token = "0x600CFA7")]
    [Address(RVA = "0x9AF250", Offset = "0x9AE050", VA = "0x109AF250")]
    private IEnumerator InitializeUnitUnlockTobira() => (IEnumerator) null;

    [Token(Token = "0x600CFA8")]
    [Address(RVA = "0x9AF020", Offset = "0x9ADE20", VA = "0x109AF020")]
    private IEnumerator InitializeUnitEnhanceTobira() => (IEnumerator) null;

    [Token(Token = "0x600CFA9")]
    [Address(RVA = "0x9AF1E0", Offset = "0x9ADFE0", VA = "0x109AF1E0")]
    private IEnumerator InitializeUnitRune() => (IEnumerator) null;

    [Token(Token = "0x600CFAA")]
    [Address(RVA = "0x9AEDA0", Offset = "0x9ADBA0", VA = "0x109AEDA0")]
    private void InitUnitModelPreviewBase()
    {
    }

    [Token(Token = "0x600CFAB")]
    [Address(RVA = "0x9AEF30", Offset = "0x9ADD30", VA = "0x109AEF30")]
    private IEnumerator InitializeUnitCrystalEquip() => (IEnumerator) null;

    [Token(Token = "0x600CFAC")]
    [Address(RVA = "0x9AE300", Offset = "0x9AD100", VA = "0x109AE300")]
    public void ChangeUnitPreviewPos(bool is_unit_detail)
    {
    }

    [Token(Token = "0x600CFAD")]
    [Address(RVA = "0x9AF6D0", Offset = "0x9AE4D0", VA = "0x109AF6D0")]
    private void Release()
    {
    }

    [Token(Token = "0x600CFAE")]
    [Address(RVA = "0x9AE680", Offset = "0x9AD480", VA = "0x109AE680")]
    public void CreateUnitList()
    {
    }

    [Token(Token = "0x600CFAF")]
    [Address(RVA = "0x9AE4F0", Offset = "0x9AD2F0", VA = "0x109AE4F0")]
    public void CreateNotEnableUnitList()
    {
    }

    [Token(Token = "0x600CFB0")]
    [Address(RVA = "0x9AE7D0", Offset = "0x9AD5D0", VA = "0x109AE7D0")]
    public void DestroyUnitList()
    {
    }

    [Token(Token = "0x600CFB1")]
    [Address(RVA = "0x9AE8D0", Offset = "0x9AD6D0", VA = "0x109AE8D0")]
    private List<long> GetDefaultUnitList(long selectUniq) => (List<long>) null;

    [Token(Token = "0x600CFB2")]
    [Address(RVA = "0x9AEC10", Offset = "0x9ADA10", VA = "0x109AEC10")]
    private int GetOutputPinByRestorePoint(RestorePoints rp) => new int();

    [Token(Token = "0x600CFB3")]
    [Address(RVA = "0x9AE1A0", Offset = "0x9ACFA0", VA = "0x109AE1A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CFB4")]
    [Address(RVA = "0x9AF330", Offset = "0x9AE130", VA = "0x109AF330")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600CFB5")]
    [Address(RVA = "0x9AF630", Offset = "0x9AE430", VA = "0x109AF630")]
    private void OnUnitSelect(long uniqueID)
    {
    }

    [Token(Token = "0x600CFB6")]
    [Address(RVA = "0x9AF340", Offset = "0x9AE140", VA = "0x109AF340")]
    private void OnUEWindowClosedByUser()
    {
    }

    [Token(Token = "0x600CFB7")]
    [Address(RVA = "0x9AFA20", Offset = "0x9AE820", VA = "0x109AFA20")]
    public UnitManagementWindow()
    {
    }
  }
}
