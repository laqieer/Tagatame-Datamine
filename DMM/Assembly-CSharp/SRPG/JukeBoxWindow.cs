// Decompiled with JetBrains decompiler
// Type: SRPG.JukeBoxWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002497")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(31, "PlayList Add", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(2, "Refresh", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(21, "ToPlayList", FlowNode.PinTypes.Input, 21)]
  [AddComponentMenu("UI/Gallery/JukeBox/JukeBoxWindow")]
  [FlowNode.Pin(11, "ToMusicList", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(32, "PlayList Del", FlowNode.PinTypes.Input, 32)]
  [FlowNode.Pin(101, "Initialized", FlowNode.PinTypes.Output, 101)]
  public class JukeBoxWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A6FF")]
    private const int PIN_IN_INITIALIZE = 1;
    [Token(Token = "0x400A700")]
    private const int PIN_IN_REFRESH = 2;
    [Token(Token = "0x400A701")]
    private const int PIN_IN_TO_MUSIC_LIST = 11;
    [Token(Token = "0x400A702")]
    private const int PIN_IN_TO_PLAY_LIST = 21;
    [Token(Token = "0x400A703")]
    private const int PIN_IN_PLAY_LIST_ADD = 31;
    [Token(Token = "0x400A704")]
    private const int PIN_IN_PLAY_LIST_DEL = 32;
    [Token(Token = "0x400A705")]
    private const int PIN_OUT_INITIALIZED = 101;
    [Token(Token = "0x400A706")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [Space(5f)]
    private GameObject Window;
    [Token(Token = "0x400A707")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject GoMusicListTop;
    [Token(Token = "0x400A708")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GoPlayListTop;
    [Token(Token = "0x400A709")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject EmptyPlayListText;
    [Token(Token = "0x400A70A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Space(5f)]
    private ScrollItemCentering SICSection;
    [Token(Token = "0x400A70B")]
    [FieldOffset(Offset = "0x20")]
    [Space(5f)]
    [SerializeField]
    private ContentController CcMusic;
    [Token(Token = "0x400A70C")]
    [FieldOffset(Offset = "0x24")]
    [Space(5f)]
    [SerializeField]
    private ContentController CcPlayList;
    [Token(Token = "0x400A70D")]
    [FieldOffset(Offset = "0x28")]
    [Space(5f)]
    [SerializeField]
    private GameObject PlayingBase;
    [Token(Token = "0x400A70E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject PlayingInfo;
    [Token(Token = "0x400A70F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject GoPlayListAdd;
    [Token(Token = "0x400A710")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject GoPlayListDel;
    [Token(Token = "0x400A711")]
    [FieldOffset(Offset = "0x38")]
    [Space(5f)]
    [SerializeField]
    private bool IsUnlockCondDisp;
    [Token(Token = "0x400A712")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    [Space(5f)]
    private Slider BGMVolume;
    [Token(Token = "0x400A713")]
    [FieldOffset(Offset = "0x40")]
    [Space(5f)]
    [SerializeField]
    private Text LyricsName;
    [Token(Token = "0x400A714")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject LyricsObject;
    [Token(Token = "0x400A715")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Space(5f)]
    private GameObject ExternalLinkButton;
    [Token(Token = "0x400A716")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject ExternalLinkMaskButton;
    [Token(Token = "0x400A717")]
    [FieldOffset(Offset = "0x50")]
    [Space(5f)]
    [SerializeField]
    private string StartBGMName;
    [Token(Token = "0x400A718")]
    private const float BGM_FADE_OUT_TIME = 1f;
    [Token(Token = "0x400A719")]
    private const float BGM_MYLIST_FADEOUT_TIME = 3f;
    [Token(Token = "0x400A71A")]
    private const string EVENT_TAG_NAME = "tag_end";
    [Token(Token = "0x400A71B")]
    [FieldOffset(Offset = "0x54")]
    private List<JukeBoxItemSectionParam> mSectionList;
    [Token(Token = "0x400A71C")]
    [FieldOffset(Offset = "0x0")]
    private static List<JukeBoxWindow.JukeBoxData> mJukeBoxDataList;
    [Token(Token = "0x400A71D")]
    [FieldOffset(Offset = "0x58")]
    private List<JukeBoxWindow.PlayListData> mPlayListDatas;
    [Token(Token = "0x400A71E")]
    [FieldOffset(Offset = "0x5C")]
    private JukeBoxWindow.PlayListData mCurrentPlayList;
    [Token(Token = "0x400A71F")]
    [FieldOffset(Offset = "0x60")]
    private JukeBoxItemSectionParam mCurrentSection;
    [Token(Token = "0x400A720")]
    [FieldOffset(Offset = "0x64")]
    private JukeBoxWindow.JukeBoxData mCurrentMusic;
    [Token(Token = "0x400A721")]
    [FieldOffset(Offset = "0x68")]
    private JukeBoxWindow.eMode mCurrentMode;
    [Token(Token = "0x400A722")]
    [FieldOffset(Offset = "0x6C")]
    private List<JukeBoxItemParam> mMusicItemParamList;
    [Token(Token = "0x400A723")]
    [FieldOffset(Offset = "0x70")]
    private List<JukeBoxItemParam> mPlayListItemParamList;
    [Token(Token = "0x400A724")]
    [FieldOffset(Offset = "0x74")]
    private Vector2 mAnchorPositionSection;
    [Token(Token = "0x400A725")]
    [FieldOffset(Offset = "0x7C")]
    private Dictionary<string, Vector2> mAnchorPositionMusics;
    [Token(Token = "0x400A726")]
    [FieldOffset(Offset = "0x80")]
    private Vector2 mAnchorPositionPlayList;
    [Token(Token = "0x400A727")]
    [FieldOffset(Offset = "0x4")]
    private static JukeBoxWindow mInstance;
    [Token(Token = "0x400A728")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string mPrefsKey;

    [Token(Token = "0x1700168B")]
    public static List<JukeBoxWindow.JukeBoxData> JukeBoxDataList
    {
      [Token(Token = "0x600A08A"), Address(RVA = "0x640BD0", Offset = "0x63F9D0", VA = "0x10640BD0")] get
      {
        return (List<JukeBoxWindow.JukeBoxData>) null;
      }
    }

    [Token(Token = "0x1700168C")]
    public static JukeBoxWindow Instance
    {
      [Token(Token = "0x600A08B"), Address(RVA = "0x640B90", Offset = "0x63F990", VA = "0x10640B90")] get
      {
        return (JukeBoxWindow) null;
      }
    }

    [Token(Token = "0x600A08C")]
    [Address(RVA = "0x63C790", Offset = "0x63B590", VA = "0x1063C790")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A08D")]
    [Address(RVA = "0x63E880", Offset = "0x63D680", VA = "0x1063E880")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A08E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600A08F")]
    [Address(RVA = "0x63C4B0", Offset = "0x63B2B0", VA = "0x1063C4B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A090")]
    [Address(RVA = "0x63E220", Offset = "0x63D020", VA = "0x1063E220")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600A091")]
    [Address(RVA = "0x63DA50", Offset = "0x63C850", VA = "0x1063DA50")]
    private void CreateSectionList()
    {
    }

    [Token(Token = "0x600A092")]
    [Address(RVA = "0x63CE90", Offset = "0x63BC90", VA = "0x1063CE90")]
    private void CreateMusicList(JukeBoxItemSectionParam section)
    {
    }

    [Token(Token = "0x600A093")]
    [Address(RVA = "0x63D5C0", Offset = "0x63C3C0", VA = "0x1063D5C0")]
    private void CreatePlayList()
    {
    }

    [Token(Token = "0x600A094")]
    [Address(RVA = "0x63E400", Offset = "0x63D200", VA = "0x1063E400")]
    private bool IsCurrentMusic(JukeBoxItemParam item) => new bool();

    [Token(Token = "0x600A095")]
    [Address(RVA = "0x63E0D0", Offset = "0x63CED0", VA = "0x1063E0D0")]
    private void EventTagCallback(string eventParamsString)
    {
    }

    [Token(Token = "0x600A096")]
    [Address(RVA = "0x63FB00", Offset = "0x63E900", VA = "0x1063FB00")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A097")]
    [Address(RVA = "0x63E000", Offset = "0x63CE00", VA = "0x1063E000")]
    private void CurrentModeChange(JukeBoxWindow.eMode mode, bool is_forced = false)
    {
    }

    [Token(Token = "0x600A098")]
    [Address(RVA = "0x63F320", Offset = "0x63E120", VA = "0x1063F320")]
    private void PlayListAdd()
    {
    }

    [Token(Token = "0x600A099")]
    [Address(RVA = "0x63F4C0", Offset = "0x63E2C0", VA = "0x1063F4C0")]
    private void PlayListDel()
    {
    }

    [Token(Token = "0x600A09A")]
    [Address(RVA = "0x63FC50", Offset = "0x63EA50", VA = "0x1063FC50")]
    private void SetCurrentAllItem(JukeBoxWindow.JukeBoxData data)
    {
    }

    [Token(Token = "0x600A09B")]
    [Address(RVA = "0x63CD10", Offset = "0x63BB10", VA = "0x1063CD10")]
    private void ClearCurrentAllItem()
    {
    }

    [Token(Token = "0x600A09C")]
    [Address(RVA = "0x63ECC0", Offset = "0x63DAC0", VA = "0x1063ECC0")]
    private void OnTapItemSection(JukeBoxItemSectionParam item_section, int _count = -1)
    {
    }

    [Token(Token = "0x600A09D")]
    [Address(RVA = "0x63EF00", Offset = "0x63DD00", VA = "0x1063EF00")]
    private void OnTapItem(JukeBoxWindow.JukeBoxData data, JukeBoxItemParam param)
    {
    }

    [Token(Token = "0x600A09E")]
    [Address(RVA = "0x63E420", Offset = "0x63D220", VA = "0x1063E420")]
    private bool IsEntryPlayList(JukeBoxParam param) => new bool();

    [Token(Token = "0x600A09F")]
    [Address(RVA = "0x63FA50", Offset = "0x63E850", VA = "0x1063FA50")]
    private void RefrectPlayListAddDel(bool is_entry_play_list)
    {
    }

    [Token(Token = "0x600A0A0")]
    [Address(RVA = "0x63F650", Offset = "0x63E450", VA = "0x1063F650")]
    private void Play(JukeBoxWindow.JukeBoxData data, bool _is_mylist_fade = false)
    {
    }

    [Token(Token = "0x600A0A1")]
    [Address(RVA = "0x63CC90", Offset = "0x63BA90", VA = "0x1063CC90")]
    private IEnumerator ChangeJukeBoxParamWait(JukeBoxParam _param, float _wait_time)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600A0A2")]
    [Address(RVA = "0x640480", Offset = "0x63F280", VA = "0x10640480")]
    private void Stop()
    {
    }

    [Token(Token = "0x600A0A3")]
    [Address(RVA = "0x63E9D0", Offset = "0x63D7D0", VA = "0x1063E9D0")]
    private void OnTapItemLocked(JukeBoxWindow.JukeBoxData data)
    {
    }

    [Token(Token = "0x600A0A4")]
    [Address(RVA = "0x63E6F0", Offset = "0x63D4F0", VA = "0x1063E6F0")]
    private void LongTapItem(JukeBoxWindow.JukeBoxData data)
    {
    }

    [Token(Token = "0x600A0A5")]
    [Address(RVA = "0x63F8B0", Offset = "0x63E6B0", VA = "0x1063F8B0")]
    public static bool ReflectJukeboxUnlockData(string[] bgm_list) => new bool();

    [Token(Token = "0x600A0A6")]
    [Address(RVA = "0x63FDF0", Offset = "0x63EBF0", VA = "0x1063FDF0")]
    public static bool SetJukeboxPlayListData(JukeBoxWindow.ResPlayList[] playlists) => new bool();

    [Token(Token = "0x600A0A7")]
    [Address(RVA = "0x63E180", Offset = "0x63CF80", VA = "0x1063E180")]
    public static JukeBoxWindow.JukeBoxData GetCurrentJukeBoxData()
    {
      return (JukeBoxWindow.JukeBoxData) null;
    }

    [Token(Token = "0x600A0A8")]
    [Address(RVA = "0x640510", Offset = "0x63F310", VA = "0x10640510")]
    public static void UnlockMusic(string[] bgms)
    {
    }

    [Token(Token = "0x600A0A9")]
    [Address(RVA = "0x63E500", Offset = "0x63D300", VA = "0x1063E500")]
    private static JukeBoxWindow.PrefsUnlockBadgeInfo LoadPrefsUnlockBadgeData()
    {
      return (JukeBoxWindow.PrefsUnlockBadgeInfo) null;
    }

    [Token(Token = "0x600A0AA")]
    [Address(RVA = "0x63FBC0", Offset = "0x63E9C0", VA = "0x1063FBC0")]
    private static bool SavePrefsUnlockBadgeData(JukeBoxWindow.PrefsUnlockBadgeInfo info)
    {
      return new bool();
    }

    [Token(Token = "0x600A0AB")]
    [Address(RVA = "0x63E7E0", Offset = "0x63D5E0", VA = "0x1063E7E0")]
    public void OnClickURLLink()
    {
    }

    [Token(Token = "0x600A0AC")]
    [Address(RVA = "0x640340", Offset = "0x63F140", VA = "0x10640340")]
    private void SetLyricsName(JukeBoxParam param)
    {
    }

    [Token(Token = "0x600A0AD")]
    [Address(RVA = "0x640A00", Offset = "0x63F800", VA = "0x10640A00")]
    public JukeBoxWindow()
    {
    }

    [Token(Token = "0x600A0AE")]
    [Address(RVA = "0x640910", Offset = "0x63F710", VA = "0x10640910")]
    static JukeBoxWindow()
    {
    }

    [Token(Token = "0x2002498")]
    public class JukeBoxData
    {
      [Token(Token = "0x400A729")]
      [FieldOffset(Offset = "0x8")]
      public JukeBoxParam param;
      [Token(Token = "0x400A72A")]
      [FieldOffset(Offset = "0xC")]
      public bool is_unlock;

      [Token(Token = "0x600A0AF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JukeBoxData()
      {
      }
    }

    [Token(Token = "0x2002499")]
    private class PlayListData
    {
      [Token(Token = "0x400A72B")]
      [FieldOffset(Offset = "0x8")]
      public int index;
      [Token(Token = "0x400A72C")]
      [FieldOffset(Offset = "0xC")]
      public List<JukeBoxWindow.JukeBoxData> bgm_list;

      [Token(Token = "0x600A0B0")]
      [Address(RVA = "0x640C10", Offset = "0x63FA10", VA = "0x10640C10")]
      public PlayListData()
      {
      }
    }

    [Token(Token = "0x200249A")]
    private enum eMode
    {
      [Token(Token = "0x400A72E")] MUSIC_LIST,
      [Token(Token = "0x400A72F")] PLAY_LIST,
    }

    [Token(Token = "0x200249B")]
    [MessagePackObject(true)]
    [Serializable]
    public class ResPlayList
    {
      [Token(Token = "0x400A730")]
      [FieldOffset(Offset = "0x8")]
      public int index;
      [Token(Token = "0x400A731")]
      [FieldOffset(Offset = "0xC")]
      public string[] bgm_list;

      [Token(Token = "0x600A0B1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ResPlayList()
      {
      }
    }

    [Token(Token = "0x200249C")]
    [Serializable]
    public class PrefsUnlockBadgeInfo
    {
      [Token(Token = "0x400A732")]
      [FieldOffset(Offset = "0x8")]
      public List<JukeBoxWindow.PrefsUnlockBadgeInfo.Data> list;

      [Token(Token = "0x600A0B2")]
      [Address(RVA = "0x640C80", Offset = "0x63FA80", VA = "0x10640C80")]
      public PrefsUnlockBadgeInfo()
      {
      }

      [Token(Token = "0x200249D")]
      [Serializable]
      public class Data
      {
        [Token(Token = "0x400A733")]
        [FieldOffset(Offset = "0x8")]
        public string mIname;
        [Token(Token = "0x400A734")]
        [FieldOffset(Offset = "0xC")]
        public string mSection;

        [Token(Token = "0x600A0B3")]
        [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
        public Data(string iname, string section)
        {
        }
      }
    }
  }
}
