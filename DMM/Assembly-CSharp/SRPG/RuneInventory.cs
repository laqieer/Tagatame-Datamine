// Decompiled with JetBrains decompiler
// Type: SRPG.RuneInventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029AC")]
  [FlowNode.Pin(101, "ヘルプ画面を表示", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(100, "ルーン画面を閉じる", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(211, "刻印交換：表示", FlowNode.PinTypes.Output, 211)]
  [FlowNode.Pin(60, "ルーン逆引きを開く", FlowNode.PinTypes.Input, 60)]
  [FlowNode.Pin(110, "傲慢刻印ボタンタップ", FlowNode.PinTypes.Input, 110)]
  [AddComponentMenu("UI/Rune/RuneInventory")]
  [FlowNode.Pin(10, "ルーンスロット１選択", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(201, "刻印交換：入力", FlowNode.PinTypes.Input, 201)]
  [FlowNode.Pin(50, "装備分解", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(70, "ルーン所持一覧の更新", FlowNode.PinTypes.Input, 70)]
  [FlowNode.Pin(42, "装備すべて外す通信開始", FlowNode.PinTypes.Output, 42)]
  [FlowNode.Pin(9, "表示更新", FlowNode.PinTypes.Input, 9)]
  [FlowNode.Pin(43, "装備すべて外す通信完了", FlowNode.PinTypes.Input, 43)]
  [FlowNode.Pin(8, "表示更新：一覧も含める", FlowNode.PinTypes.Input, 8)]
  [FlowNode.Pin(1, "セットアップ完了", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(12, "ルーンスロット３選択", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(13, "ルーンスロット４選択", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(11, "ルーンスロット２選択", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(0, "セットアップ開始", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(15, "ルーンスロット６選択", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(40, "装備すべて外す", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(41, "装備すべて外す確認画面へ", FlowNode.PinTypes.Output, 41)]
  [FlowNode.Pin(14, "ルーンスロット５選択", FlowNode.PinTypes.Input, 14)]
  public class RuneInventory : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C9E8")]
    private const int OUTPUT_SETUP_START = 0;
    [Token(Token = "0x400C9E9")]
    private const int INPUT_SETUP_FINISH = 1;
    [Token(Token = "0x400C9EA")]
    private const int INPUT_RUNE_REFRESH_SELECTABLE = 8;
    [Token(Token = "0x400C9EB")]
    private const int INPUT_RUNE_REFRESH = 9;
    [Token(Token = "0x400C9EC")]
    private const int INPUT_RUNE_SELECT_SLOT_1 = 10;
    [Token(Token = "0x400C9ED")]
    private const int INPUT_RUNE_SELECT_SLOT_2 = 11;
    [Token(Token = "0x400C9EE")]
    private const int INPUT_RUNE_SELECT_SLOT_3 = 12;
    [Token(Token = "0x400C9EF")]
    private const int INPUT_RUNE_SELECT_SLOT_4 = 13;
    [Token(Token = "0x400C9F0")]
    private const int INPUT_RUNE_SELECT_SLOT_5 = 14;
    [Token(Token = "0x400C9F1")]
    private const int INPUT_RUNE_SELECT_SLOT_6 = 15;
    [Token(Token = "0x400C9F2")]
    private const int INPUT_RUNE_UNEQUIP_ALL = 40;
    [Token(Token = "0x400C9F3")]
    private const int OUTPUT_RUNE_UNEQUIP_ALL = 41;
    [Token(Token = "0x400C9F4")]
    private const int OUTPUT_START_NETWORK_UNEQUIP_ALL = 42;
    [Token(Token = "0x400C9F5")]
    private const int INPUT_FINISH_NETWORK_UNEQUIP_ALL = 43;
    [Token(Token = "0x400C9F6")]
    private const int INPUT_RUNE_DISASSEMBLY = 50;
    [Token(Token = "0x400C9F7")]
    private const int INPUT_RUNE_DROP_WINDOW_OPEN = 60;
    [Token(Token = "0x400C9F8")]
    private const int INPUT_RUNE_SELECTABLE_LIST_REFRESH = 70;
    [Token(Token = "0x400C9F9")]
    private const int INPUT_RUNE_CLOSE = 100;
    [Token(Token = "0x400C9FA")]
    private const int INPUT_RUNE_HELP = 101;
    [Token(Token = "0x400C9FB")]
    private const int INPUT_RUNEPRIDE_BUTTON = 110;
    [Token(Token = "0x400C9FC")]
    private const int INPUT_RUNE_EXCHANGE = 201;
    [Token(Token = "0x400C9FD")]
    private const int OUTPUT_RUNE_EXCHANGE = 211;
    [Token(Token = "0x400C9FE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneManager mRuneManager;
    [Token(Token = "0x400C9FF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject UnitNamePlate;
    [Token(Token = "0x400CA00")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mSelectableListParent;
    [Token(Token = "0x400CA01")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mEquipPopupParent;
    [Token(Token = "0x400CA02")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mUnEquipPopupParent;
    [Token(Token = "0x400CA03")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mDisassemblyParent;
    [Token(Token = "0x400CA04")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mRunePrideParent;
    [Token(Token = "0x400CA05")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string PREFAB_PATH_RUNE_DROP_QUEST_WINDOW;
    [Token(Token = "0x400CA06")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private List<GameObject> mDisableToolTipList;
    [Token(Token = "0x400CA07")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool mIsIncludeOverWrite;
    [Token(Token = "0x400CA08")]
    [FieldOffset(Offset = "0x0")]
    public static string DEFAULT_PATH_RUNE_INVENTORY_WINDOW;
    [Token(Token = "0x400CA09")]
    [FieldOffset(Offset = "0x4")]
    private static RuneInventory mInstance;
    [Token(Token = "0x400CA0A")]
    [FieldOffset(Offset = "0x34")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400CA0B")]
    [FieldOffset(Offset = "0x38")]
    private bool mIsRestore;
    [Token(Token = "0x400CA0C")]
    [FieldOffset(Offset = "0x3C")]
    private GameObject mRuneDropQuestWindow;
    [Token(Token = "0x400CA0D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RunePrideButton RPButton;
    [Token(Token = "0x400CA0E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SRPG_Button RuneReplaceButton;

    [Token(Token = "0x17001992")]
    public static RuneInventory Instance
    {
      [Token(Token = "0x600BD37"), Address(RVA = "0x84EF20", Offset = "0x84DD20", VA = "0x1084EF20")] get
      {
        return (RuneInventory) null;
      }
    }

    [Token(Token = "0x17001993")]
    public bool IsIncludeOverWrite
    {
      [Token(Token = "0x600BD38"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BD39")]
    [Address(RVA = "0x84DE30", Offset = "0x84CC30", VA = "0x1084DE30")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BD3A")]
    [Address(RVA = "0x84DFF0", Offset = "0x84CDF0", VA = "0x1084DFF0")]
    public void Destroy()
    {
    }

    [Token(Token = "0x600BD3B")]
    [Address(RVA = "0x84E0A0", Offset = "0x84CEA0", VA = "0x1084E0A0")]
    public void Init(bool is_restore, RuneManager.DrawType type = RuneManager.DrawType.ENHANCE)
    {
    }

    [Token(Token = "0x600BD3C")]
    [Address(RVA = "0x84EAF0", Offset = "0x84D8F0", VA = "0x1084EAF0")]
    private void Setup()
    {
    }

    [Token(Token = "0x600BD3D")]
    [Address(RVA = "0x84E7C0", Offset = "0x84D5C0", VA = "0x1084E7C0")]
    public void ResetUnit()
    {
    }

    [Token(Token = "0x600BD3E")]
    [Address(RVA = "0x84E3A0", Offset = "0x84D1A0", VA = "0x1084E3A0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BD3F")]
    [Address(RVA = "0x84E580", Offset = "0x84D380", VA = "0x1084E580")]
    private bool RefreshCurrentUnit() => new bool();

    [Token(Token = "0x600BD40")]
    [Address(RVA = "0x84D9A0", Offset = "0x84C7A0", VA = "0x1084D9A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BD41")]
    [Address(RVA = "0x84ED60", Offset = "0x84DB60", VA = "0x1084ED60")]
    private void StartEquipEffect()
    {
    }

    [Token(Token = "0x600BD42")]
    [Address(RVA = "0x84E570", Offset = "0x84D370", VA = "0x1084E570")]
    private void RefreshAll()
    {
    }

    [Token(Token = "0x600BD43")]
    [Address(RVA = "0x84E920", Offset = "0x84D720", VA = "0x1084E920")]
    public void SetParentPopupObject(GameObject obj, RuneInventory.WindowParent type)
    {
    }

    [Token(Token = "0x600BD44")]
    [Address(RVA = "0x84E710", Offset = "0x84D510", VA = "0x1084E710")]
    private void RefreshNamePlate()
    {
    }

    [Token(Token = "0x600BD45")]
    [Address(RVA = "0x84E430", Offset = "0x84D230", VA = "0x1084E430")]
    private void OpenRuneDropQuestWindow(bool is_restore)
    {
    }

    [Token(Token = "0x600BD46")]
    [Address(RVA = "0x84DEE0", Offset = "0x84CCE0", VA = "0x1084DEE0")]
    public static RuneInventory CreateRuneInventory(string path, Transform transform)
    {
      return (RuneInventory) null;
    }

    [Token(Token = "0x600BD47")]
    [Address(RVA = "0x84E370", Offset = "0x84D170", VA = "0x1084E370")]
    private bool IsOpenRunePride() => new bool();

    [Token(Token = "0x600BD48")]
    [Address(RVA = "0x84E8A0", Offset = "0x84D6A0", VA = "0x1084E8A0")]
    private bool RuneExchangePreparation() => new bool();

    [Token(Token = "0x600BD49")]
    [Address(RVA = "0x84EE90", Offset = "0x84DC90", VA = "0x1084EE90")]
    public RuneInventory()
    {
    }

    [Token(Token = "0x600BD4A")]
    [Address(RVA = "0x84EE20", Offset = "0x84DC20", VA = "0x1084EE20")]
    static RuneInventory()
    {
    }

    [Token(Token = "0x20029AD")]
    public enum WindowParent
    {
      [Token(Token = "0x400CA10")] SelectableList,
      [Token(Token = "0x400CA11")] EquipPopup,
      [Token(Token = "0x400CA12")] UnEquipPopup,
      [Token(Token = "0x400CA13")] Disassembly,
      [Token(Token = "0x400CA14")] RunePrideParam,
    }
  }
}
