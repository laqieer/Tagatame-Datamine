// Decompiled with JetBrains decompiler
// Type: SRPG.WorldMapManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D39")]
  [AddComponentMenu("UI/World/WorldMapManager")]
  [FlowNode.Pin(120, "「クエスト」を表示するべき", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(110, "「幕」を表示するべき", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(40, "「クエスト」 表示", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(100, "「部」選択UIを表示するべき", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(20, "「章」 表示", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(30, "「幕」 表示", FlowNode.PinTypes.Input, 30)]
  public class WorldMapManager : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E170")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x400E171")]
    private const int PIN_INPUT_DISPLAY_SECTION = 20;
    [Token(Token = "0x400E172")]
    private const int PIN_INPUT_DISPLAY_CHAPTER = 30;
    [Token(Token = "0x400E173")]
    private const int PIN_INPUT_DISPLAY_QUEST = 40;
    [Token(Token = "0x400E174")]
    private const int PIN_OUTPUT_OPEN_SELECT_PART_UI = 100;
    [Token(Token = "0x400E175")]
    private const int PIN_OUTPUT_DISPLAY_CHAPTER = 110;
    [Token(Token = "0x400E176")]
    private const int PIN_OUTPUT_DISPLAY_QUEST = 120;
    [Token(Token = "0x400E177")]
    [FieldOffset(Offset = "0xC")]
    private WorldMapManager.eViewType mCurrentViewType;
    [Token(Token = "0x400E178")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mSectionList;
    [Token(Token = "0x400E179")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mChapterList;
    [Token(Token = "0x400E17A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mQuestSelector;
    [Token(Token = "0x400E17B")]
    [FieldOffset(Offset = "0x0")]
    private static WorldMapManager mInstance;

    [Token(Token = "0x17001B9E")]
    public WorldMapManager.eViewType CurrentViewType
    {
      [Token(Token = "0x600D2C5"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new WorldMapManager.eViewType();
      }
    }

    [Token(Token = "0x17001B9F")]
    public GameObject SectionList
    {
      [Token(Token = "0x600D2C6"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001BA0")]
    public static WorldMapManager Instance
    {
      [Token(Token = "0x600D2C7"), Address(RVA = "0x9E1640", Offset = "0x9E0440", VA = "0x109E1640")] get
      {
        return (WorldMapManager) null;
      }
    }

    [Token(Token = "0x600D2C8")]
    [Address(RVA = "0x9E0F70", Offset = "0x9DFD70", VA = "0x109E0F70")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D2C9")]
    [Address(RVA = "0x9E15C0", Offset = "0x9E03C0", VA = "0x109E15C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D2CA")]
    [Address(RVA = "0x9E0DA0", Offset = "0x9DFBA0", VA = "0x109E0DA0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D2CB")]
    [Address(RVA = "0x9E12F0", Offset = "0x9E00F0", VA = "0x109E12F0")]
    private void Init()
    {
    }

    [Token(Token = "0x600D2CC")]
    [Address(RVA = "0x9E1190", Offset = "0x9DFF90", VA = "0x109E1190")]
    private void Disp_SectionList()
    {
    }

    [Token(Token = "0x600D2CD")]
    [Address(RVA = "0x9E0FB0", Offset = "0x9DFDB0", VA = "0x109E0FB0")]
    private void Disp_ChapterList()
    {
    }

    [Token(Token = "0x600D2CE")]
    [Address(RVA = "0x9E1080", Offset = "0x9DFE80", VA = "0x109E1080")]
    private void Disp_QuestSelector(bool is_skip_focus_anim = false)
    {
    }

    [Token(Token = "0x600D2CF")]
    [Address(RVA = "0x9E14F0", Offset = "0x9E02F0", VA = "0x109E14F0")]
    private bool IsSelected() => new bool();

    [Token(Token = "0x600D2D0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WorldMapManager()
    {
    }

    [Token(Token = "0x2002D3A")]
    public enum eViewType
    {
      [Token(Token = "0x400E17D")] None,
      [Token(Token = "0x400E17E")] Section,
      [Token(Token = "0x400E17F")] Chapter,
      [Token(Token = "0x400E180")] Quest,
    }
  }
}
