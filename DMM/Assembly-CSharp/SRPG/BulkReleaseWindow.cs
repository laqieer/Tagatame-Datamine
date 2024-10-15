// Decompiled with JetBrains decompiler
// Type: SRPG.BulkReleaseWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002357")]
  [FlowNode.Pin(999, "閉じる", FlowNode.PinTypes.Output, 999)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "入力：OK", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(21, "入力：CANCEL", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(31, "API実行", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(99, "初期化完了", FlowNode.PinTypes.Output, 99)]
  [FlowNode.Pin(101, "確認", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(114, "個別：幻影記憶", FlowNode.PinTypes.Output, 114)]
  [FlowNode.Pin(213, "全て：刻印", FlowNode.PinTypes.Output, 213)]
  [FlowNode.Pin(214, "全て：幻影記憶", FlowNode.PinTypes.Output, 214)]
  [FlowNode.Pin(113, "個別：刻印", FlowNode.PinTypes.Output, 113)]
  public class BulkReleaseWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009E57")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x4009E58")]
    private const int PIN_IN_OK = 11;
    [Token(Token = "0x4009E59")]
    private const int PIN_IN_CANCEL = 21;
    [Token(Token = "0x4009E5A")]
    private const int PIN_IN_DECISION = 31;
    [Token(Token = "0x4009E5B")]
    private const int PIN_OUT_INIT = 99;
    [Token(Token = "0x4009E5C")]
    private const int PIN_OUT_CONFIRM = 101;
    [Token(Token = "0x4009E5D")]
    private const int PIN_OUT_SINGLE_BULK_RELEASE_RUNE = 113;
    [Token(Token = "0x4009E5E")]
    private const int PIN_OUT_SINGLE_BULK_RELEASE_CRYSTAL = 114;
    [Token(Token = "0x4009E5F")]
    private const int PIN_OUT_ALL_BULK_RELEASE_RUNE = 213;
    [Token(Token = "0x4009E60")]
    private const int PIN_OUT_ALL_BULK_RELEASE_CRYSTAL = 214;
    [Token(Token = "0x4009E61")]
    private const int PIN_OUT_CLOSE = 999;
    [Token(Token = "0x4009E62")]
    public const string SVB_KEY_BULK_RELREASE_TYPE = "SVB_KEY_BULK_RELREASE_TYPE";
    [Token(Token = "0x4009E63")]
    public const string SVB_KEY_OPEN_LEAGUE_MATCH = "SVB_KEY_OPEN_LEAGUE_MATCH";
    [Token(Token = "0x4009E64")]
    public const string SVB_KEY_BULK_RELREASE_TARGET_ID = "SVB_KEY_BULK_RELREASE_TARGET_ID";
    [Token(Token = "0x4009E65")]
    public const string SVB_KEY_BULK_RELREASE_PARTY_TYPES = "SVB_KEY_BULK_RELREASE_PARTY_TYPES";
    [Token(Token = "0x4009E66")]
    public const string SVB_KEY_BULK_RELREASE_IS_COMMON = "SVB_KEY_BULK_RELREASE_IS_COMMON";
    [Token(Token = "0x4009E67")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x4009E68")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mInitExhibitList;
    [Token(Token = "0x4009E69")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x4009E6A")]
    [FieldOffset(Offset = "0x18")]
    private BulkReleaseWindowModel mModel;

    [Token(Token = "0x6009856")]
    [Address(RVA = "0x5A87F0", Offset = "0x5A75F0", VA = "0x105A87F0")]
    public void LoadSVB()
    {
    }

    [Token(Token = "0x6009857")]
    [Address(RVA = "0x5A8BD0", Offset = "0x5A79D0", VA = "0x105A8BD0")]
    public void SaveSVB()
    {
    }

    [Token(Token = "0x6009858")]
    [Address(RVA = "0x5A86E0", Offset = "0x5A74E0", VA = "0x105A86E0")]
    public void Initialize(BulkReleaseWindow.Type type, long iid, bool isLeagueMatch)
    {
    }

    [Token(Token = "0x6009859")]
    [Address(RVA = "0x5A8B10", Offset = "0x5A7910", VA = "0x105A8B10")]
    public void Refresh(bool init = false)
    {
    }

    [Token(Token = "0x600985A")]
    [Address(RVA = "0x5A8610", Offset = "0x5A7410", VA = "0x105A8610")]
    private void EquipReleaseAPI()
    {
    }

    [Token(Token = "0x600985B")]
    [Address(RVA = "0x5A8570", Offset = "0x5A7370", VA = "0x105A8570")]
    private void ConfirmWindow()
    {
    }

    [Token(Token = "0x600985C")]
    [Address(RVA = "0x5A83A0", Offset = "0x5A71A0", VA = "0x105A83A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600985D")]
    [Address(RVA = "0x5A8A40", Offset = "0x5A7840", VA = "0x105A8A40")]
    public void OnToggle(PartyToggle node)
    {
    }

    [Token(Token = "0x600985E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BulkReleaseWindow()
    {
    }

    [Token(Token = "0x2002358")]
    public enum Type
    {
      [Token(Token = "0x4009E6C")] None,
      [Token(Token = "0x4009E6D")] Rune,
      [Token(Token = "0x4009E6E")] Crystal,
    }

    [Token(Token = "0x2002359")]
    public enum EquipPartyType
    {
      [Token(Token = "0x4009E70")] None,
      [Token(Token = "0x4009E71")] Arena,
      [Token(Token = "0x4009E72")] Support,
      [Token(Token = "0x4009E73")] GvG,
      [Token(Token = "0x4009E74")] LeagueMatch,
    }
  }
}
