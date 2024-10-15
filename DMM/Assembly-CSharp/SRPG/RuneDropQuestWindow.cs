// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDropQuestWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002998")]
  [AddComponentMenu("UI/Rune/RuneDropQuestWindow")]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "閉じる直前準備", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(100, "クエスト選択した", FlowNode.PinTypes.Output, 100)]
  public class RuneDropQuestWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C8FB")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x400C8FC")]
    private const int PIN_INPUT_SETUP_DESTROY = 20;
    [Token(Token = "0x400C8FD")]
    private const int PIN_OUTPUT_SELECT_QUEST = 100;
    [Token(Token = "0x400C8FE")]
    [FieldOffset(Offset = "0xC")]
    private readonly string SVB_KEY_SET_EFF_ICON_ON;
    [Token(Token = "0x400C8FF")]
    [FieldOffset(Offset = "0x10")]
    private readonly string SVB_KEY_SET_EFF_ICON_OFF;
    [Token(Token = "0x400C900")]
    [FieldOffset(Offset = "0x14")]
    private readonly string SVB_KEY_SET_EFF_TEXT_ON;
    [Token(Token = "0x400C901")]
    [FieldOffset(Offset = "0x18")]
    private readonly string SVB_KEY_SET_EFF_TEXT_OFF;
    [Token(Token = "0x400C902")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string GAMEOBJECT_ID_EQUIP_SETEFFECT_DETAIL;
    [Token(Token = "0x400C903")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform mEquipedSetEffectDetailParent;
    [Token(Token = "0x400C904")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SRPG_Button mQuestContentTemplate;
    [Token(Token = "0x400C905")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Toggle mRuneSetEffectTabTemplate;
    [Token(Token = "0x400C906")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Toggle[] mRuneSlotTabs;
    [Token(Token = "0x400C907")]
    [FieldOffset(Offset = "0x30")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string mSingleQuestDetailPrefabPath;
    [Token(Token = "0x400C908")]
    [FieldOffset(Offset = "0x34")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string mMultiQuestDetailPrefabPath;
    [Token(Token = "0x400C909")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SRPG_ScrollRect ScrollRectController;
    [Token(Token = "0x400C90A")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private CalcPositionScrollRect mPosCalculator;
    [Token(Token = "0x400C90B")]
    [FieldOffset(Offset = "0x40")]
    private float BITING_PREVENT_VELOCITY;
    [Token(Token = "0x400C90C")]
    [FieldOffset(Offset = "0x44")]
    private Transform mPreEquipedSetEffectDetailParent;
    [Token(Token = "0x400C90D")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<int, Dictionary<byte, List<QuestParam>>> mDropQuestTable;
    [Token(Token = "0x400C90E")]
    [FieldOffset(Offset = "0x4C")]
    private List<SRPG_Button> mQuestContentList;
    [Token(Token = "0x400C90F")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<int, Toggle> mRuneSetEffectTabs;
    [Token(Token = "0x400C910")]
    [FieldOffset(Offset = "0x0")]
    private static int SELECTED_RUNE_SLOT_INDEX;
    [Token(Token = "0x400C911")]
    [FieldOffset(Offset = "0x4")]
    private static int SELECTED_RUNE_SET_EFFECT_INDEX;

    [Token(Token = "0x17001988")]
    public static bool IsSelectedTab
    {
      [Token(Token = "0x600BC83"), Address(RVA = "0x844540", Offset = "0x843340", VA = "0x10844540")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BC84")]
    [Address(RVA = "0x842070", Offset = "0x840E70", VA = "0x10842070")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BC85")]
    [Address(RVA = "0x841F20", Offset = "0x840D20", VA = "0x10841F20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BC86")]
    [Address(RVA = "0x843E90", Offset = "0x842C90", VA = "0x10843E90")]
    private void SetupDestroy()
    {
    }

    [Token(Token = "0x600BC87")]
    [Address(RVA = "0x842B00", Offset = "0x841900", VA = "0x10842B00")]
    public void Init(bool is_restore)
    {
    }

    [Token(Token = "0x600BC88")]
    [Address(RVA = "0x844250", Offset = "0x843050", VA = "0x10844250")]
    private void SyncSelectedTab()
    {
    }

    [Token(Token = "0x600BC89")]
    [Address(RVA = "0x842810", Offset = "0x841610", VA = "0x10842810")]
    private void GetDefaultIndex(ref int set_eff_index, ref int slot_index)
    {
    }

    [Token(Token = "0x600BC8A")]
    [Address(RVA = "0x8424F0", Offset = "0x8412F0", VA = "0x108424F0")]
    private void CreateTabs_RuneSetEffect()
    {
    }

    [Token(Token = "0x600BC8B")]
    [Address(RVA = "0x843FB0", Offset = "0x842DB0", VA = "0x10843FB0")]
    private void SetupSetEffectTab(Toggle toggle, RuneSetEff set_eff_param)
    {
    }

    [Token(Token = "0x600BC8C")]
    [Address(RVA = "0x8420C0", Offset = "0x840EC0", VA = "0x108420C0")]
    private void CreateQuestList(int rune_set_effect, int rune_slot_index)
    {
    }

    [Token(Token = "0x600BC8D")]
    [Address(RVA = "0x843590", Offset = "0x842390", VA = "0x10843590")]
    private void RemoveQuestList()
    {
    }

    [Token(Token = "0x600BC8E")]
    [Address(RVA = "0x842EF0", Offset = "0x841CF0", VA = "0x10842EF0")]
    private void OnQuestSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600BC8F")]
    private int GetDictionaryItemCount<T>(Dictionary<T, List<QuestParam>> rune_quests) => new int();

    [Token(Token = "0x600BC90")]
    [Address(RVA = "0x843420", Offset = "0x842220", VA = "0x10843420")]
    public void OpenQuestDetail(GameObject obj)
    {
    }

    [Token(Token = "0x600BC91")]
    [Address(RVA = "0x843660", Offset = "0x842460", VA = "0x10843660")]
    private void ResetSelectedData()
    {
    }

    [Token(Token = "0x600BC92")]
    [Address(RVA = "0x843BC0", Offset = "0x8429C0", VA = "0x10843BC0")]
    private void SelectTab(int set_effect_index, int slot_index, bool is_restore = false)
    {
    }

    [Token(Token = "0x600BC93")]
    [Address(RVA = "0x843AD0", Offset = "0x8428D0", VA = "0x10843AD0")]
    private void SelectTab_RuneSlot(int slot_index)
    {
    }

    [Token(Token = "0x600BC94")]
    [Address(RVA = "0x8439F0", Offset = "0x8427F0", VA = "0x108439F0")]
    public void SelectTab_RuneSlot(Toggle self)
    {
    }

    [Token(Token = "0x600BC95")]
    [Address(RVA = "0x843890", Offset = "0x842690", VA = "0x10843890")]
    private void SelectTab_RuneSetEffect(int set_effect_index, bool is_restore = false)
    {
    }

    [Token(Token = "0x600BC96")]
    [Address(RVA = "0x8436B0", Offset = "0x8424B0", VA = "0x108436B0")]
    public void SelectTab_RuneSetEffect(Toggle self)
    {
    }

    [Token(Token = "0x600BC97")]
    [Address(RVA = "0x843BF0", Offset = "0x8429F0", VA = "0x10843BF0")]
    private void SetScrollPosition()
    {
    }

    [Token(Token = "0x600BC98")]
    [Address(RVA = "0x842A80", Offset = "0x841880", VA = "0x10842A80")]
    private IEnumerator InitScrioll(Vector2 vector) => (IEnumerator) null;

    [Token(Token = "0x600BC99")]
    [Address(RVA = "0x844400", Offset = "0x843200", VA = "0x10844400")]
    public RuneDropQuestWindow()
    {
    }

    [Token(Token = "0x600BC9A")]
    [Address(RVA = "0x8443C0", Offset = "0x8431C0", VA = "0x108443C0")]
    static RuneDropQuestWindow()
    {
    }
  }
}
