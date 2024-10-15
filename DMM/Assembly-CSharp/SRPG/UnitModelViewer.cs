// Decompiled with JetBrains decompiler
// Type: SRPG.UnitModelViewer
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
  [Token(Token = "0x2002CCB")]
  [FlowNode.Pin(100, "OnBack", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/UnitModelViewer")]
  public class UnitModelViewer : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DE9C")]
    private const int TAB_ANIM_TIMEOUT = 1000;
    [Token(Token = "0x400DE9D")]
    [FieldOffset(Offset = "0xC")]
    private readonly float TOOLTIP_POSITION_OFFSET_Y;
    [Token(Token = "0x400DE9E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RectTransform JobIconParent;
    [Token(Token = "0x400DE9F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject JobNameObject;
    [Token(Token = "0x400DEA0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject TouchArea;
    [Token(Token = "0x400DEA1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform m_TabPageParent;
    [Token(Token = "0x400DEA2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject m_TabMainMenu;
    [Token(Token = "0x400DEA3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SRPG_Button SkinButton;
    [Token(Token = "0x400DEA4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SRPG_Button ReactionButton;
    [Token(Token = "0x400DEA5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button VoiceButton;
    [Token(Token = "0x400DEA6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject VoiceUnlock;
    [Token(Token = "0x400DEA7")]
    [FieldOffset(Offset = "0x34")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PLAYBACK_UNITVOICE_PREFAB_PATH;
    [Token(Token = "0x400DEA8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Tooltip Preafab_UnlockConditionsTooltip;
    [Token(Token = "0x400DEA9")]
    [FieldOffset(Offset = "0x3C")]
    public UnitModelViewer.ChangeJobSlotEvent OnChangeJobSlot;
    [Token(Token = "0x400DEAA")]
    [FieldOffset(Offset = "0x40")]
    public UnitModelViewer.SkinSelectEvent OnSkinSelect;
    [Token(Token = "0x400DEAB")]
    [FieldOffset(Offset = "0x44")]
    public UnitModelViewer.PlayReaction OnPlayReaction;
    [Token(Token = "0x400DEAC")]
    [FieldOffset(Offset = "0x48")]
    private TouchControlArea mTouchControlArea;
    [Token(Token = "0x400DEAD")]
    [FieldOffset(Offset = "0x4C")]
    private Tooltip mUnlockConditionsTooltip;
    [Token(Token = "0x400DEAE")]
    [FieldOffset(Offset = "0x50")]
    private bool mIsCreatedJobIconInstance;
    [Token(Token = "0x400DEAF")]
    [FieldOffset(Offset = "0x54")]
    private int wait_frame;
    [Token(Token = "0x400DEB0")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<int, int[]> mJobSetDatas;
    [Token(Token = "0x400DEB1")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private JobIconScrollListController mJobIconScrollListController;
    [Token(Token = "0x400DEB2")]
    [FieldOffset(Offset = "0x60")]
    private List<UnitInventoryJobIcon> mUnitJobIconSetList;
    [Token(Token = "0x400DEB3")]
    [FieldOffset(Offset = "0x64")]
    private ScrollClamped_JobIcons mScrollClampedJobIcons;
    [Token(Token = "0x400DEB4")]
    [FieldOffset(Offset = "0x68")]
    private Dictionary<int, GameObject> m_TabPages;
    [Token(Token = "0x400DEB5")]
    [FieldOffset(Offset = "0x6C")]
    private UnitModelViewer.eTabType m_ActiveTabType;
    [Token(Token = "0x400DEB6")]
    [FieldOffset(Offset = "0x70")]
    private PlayBackUnitVoice m_TabPlayBackVoiceWindow;
    [Token(Token = "0x400DEB7")]
    [FieldOffset(Offset = "0x74")]
    private UnitSkinSelectWindow m_TabSkinSelectWindow;
    [Token(Token = "0x400DEB8")]
    [FieldOffset(Offset = "0x78")]
    private EnumBitArray<UnitModelViewer.eTabType> mTabPageRefreshWhenOpen;
    [Token(Token = "0x400DEB9")]
    [FieldOffset(Offset = "0x7C")]
    private bool IsInitalized;
    [Token(Token = "0x400DEBA")]
    [FieldOffset(Offset = "0x7D")]
    private bool m_IsSkinUnlocked;
    [Token(Token = "0x400DEBB")]
    [FieldOffset(Offset = "0x7E")]
    private bool m_IsPlaybackVoiceUnlocked;
    [Token(Token = "0x400DEBC")]
    [FieldOffset(Offset = "0x80")]
    private UnitData m_CurrentUnit;

    [Token(Token = "0x17001B6E")]
    private List<UnitInventoryJobIcon> UnitJobIconSetList
    {
      [Token(Token = "0x600D050"), Address(RVA = "0x9BA5B0", Offset = "0x9B93B0", VA = "0x109BA5B0")] get
      {
        return (List<UnitInventoryJobIcon>) null;
      }
    }

    [Token(Token = "0x17001B6F")]
    private ScrollClamped_JobIcons ScrollClampedJobIcons
    {
      [Token(Token = "0x600D051"), Address(RVA = "0x9BA4D0", Offset = "0x9B92D0", VA = "0x109BA4D0")] get
      {
        return (ScrollClamped_JobIcons) null;
      }
    }

    [Token(Token = "0x600D052")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D053")]
    [Address(RVA = "0x9B9F10", Offset = "0x9B8D10", VA = "0x109B9F10")]
    private void Start()
    {
    }

    [Token(Token = "0x600D054")]
    [Address(RVA = "0x9B81F0", Offset = "0x9B6FF0", VA = "0x109B81F0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D055")]
    [Address(RVA = "0x9B8270", Offset = "0x9B7070", VA = "0x109B8270")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600D056")]
    [Address(RVA = "0x9BA380", Offset = "0x9B9180", VA = "0x109BA380")]
    private void Update()
    {
    }

    [Token(Token = "0x600D057")]
    [Address(RVA = "0x9B7E40", Offset = "0x9B6C40", VA = "0x109B7E40")]
    public void Initalize()
    {
    }

    [Token(Token = "0x600D058")]
    [Address(RVA = "0x9B9C70", Offset = "0x9B8A70", VA = "0x109B9C70")]
    public void ResetTouchControlArea()
    {
    }

    [Token(Token = "0x600D059")]
    [Address(RVA = "0x9B8280", Offset = "0x9B7080", VA = "0x109B8280")]
    public void OnJobIconClick(GameObject target)
    {
    }

    [Token(Token = "0x600D05A")]
    [Address(RVA = "0x9B83C0", Offset = "0x9B71C0", VA = "0x109B83C0")]
    private void OnSkinSelectClick()
    {
    }

    [Token(Token = "0x600D05B")]
    [Address(RVA = "0x9B83E0", Offset = "0x9B71E0", VA = "0x109B83E0")]
    public void OnSkinSelectWindowCreate(UnitSkinSelectWindow window)
    {
    }

    [Token(Token = "0x600D05C")]
    [Address(RVA = "0x9B83A0", Offset = "0x9B71A0", VA = "0x109B83A0")]
    private void OnRectionClick()
    {
    }

    [Token(Token = "0x600D05D")]
    [Address(RVA = "0x9B84A0", Offset = "0x9B72A0", VA = "0x109B84A0")]
    private void OnVoiceClick()
    {
    }

    [Token(Token = "0x600D05E")]
    [Address(RVA = "0x9B81C0", Offset = "0x9B6FC0", VA = "0x109B81C0")]
    private void OnVoiceClose()
    {
    }

    [Token(Token = "0x600D05F")]
    [Address(RVA = "0x9B81C0", Offset = "0x9B6FC0", VA = "0x109B81C0")]
    private void OnSkinSet(ArtifactParam artifact)
    {
    }

    [Token(Token = "0x600D060")]
    [Address(RVA = "0x9B81C0", Offset = "0x9B6FC0", VA = "0x109B81C0")]
    private void OnDefaultSkinSet()
    {
    }

    [Token(Token = "0x600D061")]
    [Address(RVA = "0x9BA290", Offset = "0x9B9090", VA = "0x109BA290")]
    private void UpdateJobSlotStates(bool immediate)
    {
    }

    [Token(Token = "0x600D062")]
    [Address(RVA = "0x9B7600", Offset = "0x9B6400", VA = "0x109B7600")]
    private int ClampJobIconIndex(int index) => new int();

    [Token(Token = "0x600D063")]
    [Address(RVA = "0x9B85B0", Offset = "0x9B73B0", VA = "0x109B85B0")]
    public void RefreshJobIcon(GameObject target, int job_index)
    {
    }

    [Token(Token = "0x600D064")]
    [Address(RVA = "0x9B8C90", Offset = "0x9B7A90", VA = "0x109B8C90")]
    public void Refresh(bool is_hide = false)
    {
    }

    [Token(Token = "0x600D065")]
    [Address(RVA = "0x9B8C60", Offset = "0x9B7A60", VA = "0x109B8C60")]
    private void RefreshUnlockFlags(UnitData unitData)
    {
    }

    [Token(Token = "0x600D066")]
    [Address(RVA = "0x9B8A30", Offset = "0x9B7830", VA = "0x109B8A30")]
    private void RefreshState()
    {
    }

    [Token(Token = "0x600D067")]
    [Address(RVA = "0x9B88A0", Offset = "0x9B76A0", VA = "0x109B88A0")]
    private void RefreshSkinSelectWindow()
    {
    }

    [Token(Token = "0x600D068")]
    [Address(RVA = "0x9B8750", Offset = "0x9B7550", VA = "0x109B8750")]
    private void RefreshPlayBackVoiceWindow()
    {
    }

    [Token(Token = "0x600D069")]
    [Address(RVA = "0x9B8B10", Offset = "0x9B7910", VA = "0x109B8B10")]
    private void RefreshTabPage(UnitModelViewer.eTabType tabType)
    {
    }

    [Token(Token = "0x600D06A")]
    [Address(RVA = "0x9B75C0", Offset = "0x9B63C0", VA = "0x109B75C0")]
    private void ChangeToValidTabIfInvalidTab(UnitData unitData)
    {
    }

    [Token(Token = "0x600D06B")]
    [Address(RVA = "0x9B9D30", Offset = "0x9B8B30", VA = "0x109B9D30")]
    private void ShowUnlockConditionsTooltip(GameObject _target_obj)
    {
    }

    [Token(Token = "0x600D06C")]
    [Address(RVA = "0x9B8490", Offset = "0x9B7290", VA = "0x109B8490")]
    private void OnTabChange(UnitModelViewer.eTabType tabType)
    {
    }

    [Token(Token = "0x600D06D")]
    [Address(RVA = "0x9B9CE0", Offset = "0x9B8AE0", VA = "0x109B9CE0")]
    private void SetIsTabNeedRefresh(UnitModelViewer.eTabType tab)
    {
    }

    [Token(Token = "0x600D06E")]
    [Address(RVA = "0x9B7700", Offset = "0x9B6500", VA = "0x109B7700")]
    private void ClearTabNeedRefresh(UnitModelViewer.eTabType tab)
    {
    }

    [Token(Token = "0x600D06F")]
    [Address(RVA = "0x9B8170", Offset = "0x9B6F70", VA = "0x109B8170")]
    private bool IsTabNeedRefresh(UnitModelViewer.eTabType tab) => new bool();

    [Token(Token = "0x600D070")]
    [Address(RVA = "0x9B9F20", Offset = "0x9B8D20", VA = "0x109B9F20")]
    private void TabChange(UnitModelViewer.eTabType tabType)
    {
    }

    [Token(Token = "0x600D071")]
    [Address(RVA = "0x9B7870", Offset = "0x9B6670", VA = "0x109B7870")]
    private void CreateTabPage(UnitModelViewer.eTabType tabType)
    {
    }

    [Token(Token = "0x600D072")]
    [Address(RVA = "0x9B7750", Offset = "0x9B6550", VA = "0x109B7750")]
    private GameObject CreatePlayBackUnitVoiceWindow() => (GameObject) null;

    [Token(Token = "0x600D073")]
    [Address(RVA = "0x9B8540", Offset = "0x9B7340", VA = "0x109B8540")]
    private IEnumerator PlayTabChangeAnimation(WindowController closeTab, WindowController openTab)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600D074")]
    [Address(RVA = "0x9BA3F0", Offset = "0x9B91F0", VA = "0x109BA3F0")]
    public UnitModelViewer()
    {
    }

    [Token(Token = "0x2002CCC")]
    private enum eTabType
    {
      [Token(Token = "0x400DEBE")] None,
      [Token(Token = "0x400DEBF")] MainMenu,
      [Token(Token = "0x400DEC0")] SkinSelect,
      [Token(Token = "0x400DEC1")] VoicePlayer,
    }

    [Token(Token = "0x2002CCD")]
    public delegate void ChangeJobSlotEvent(int index, GameObject target);

    [Token(Token = "0x2002CCE")]
    public delegate void SkinSelectEvent(SRPG_Button button);

    [Token(Token = "0x2002CCF")]
    public delegate void PlayReaction();
  }
}
