// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestResult
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
  [Token(Token = "0x2002065")]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "結果表示", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(100, "結果表示終了", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/AutoRepeatQuest/AutoRepeatQuestResult")]
  public class AutoRepeatQuestResult : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008B41")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x4008B42")]
    private const int PIN_INPUT_SHOW_RESULT = 20;
    [Token(Token = "0x4008B43")]
    private const int PIN_OUTPUT_SHOW_RESULT_END = 100;
    [Token(Token = "0x4008B44")]
    [FieldOffset(Offset = "0xC")]
    private LoadRequest mReqRaidResultWindow;
    [Token(Token = "0x4008B45")]
    [FieldOffset(Offset = "0x10")]
    private AutoRepeatQuestData mAutoRepeatQuestResult;
    [Token(Token = "0x4008B46")]
    [FieldOffset(Offset = "0x14")]
    private AutoRepeatQuest_OldData mOldData;
    [Token(Token = "0x4008B47")]
    [FieldOffset(Offset = "0x18")]
    private List<RuneData> mRuneDatas;
    [Token(Token = "0x4008B48")]
    [FieldOffset(Offset = "0x1C")]
    private List<Json_Disassemble> mRunesDisassemble;
    [Token(Token = "0x4008B49")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mRepeatCountText;
    [Token(Token = "0x4008B4A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mDropCountText;
    [Token(Token = "0x4008B4B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mDropMaxText;
    [Token(Token = "0x4008B4C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x4008B4D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mDropItemEmpty;
    [Token(Token = "0x4008B4E")]
    [FieldOffset(Offset = "0x34")]
    [StringIsResourcePath(typeof (RaidResultWindow))]
    [SerializeField]
    private string mRaidResultPrefab;
    [Token(Token = "0x4008B4F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SerializeValueBehaviour mSerializeValueBehaviour;

    [Token(Token = "0x6008697")]
    [Address(RVA = "0x47F340", Offset = "0x47E140", VA = "0x1047F340", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008698")]
    [Address(RVA = "0x47F370", Offset = "0x47E170", VA = "0x1047F370")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008699")]
    [Address(RVA = "0x47F3A0", Offset = "0x47E1A0", VA = "0x1047F3A0")]
    private void Init()
    {
    }

    [Token(Token = "0x600869A")]
    [Address(RVA = "0x47FE30", Offset = "0x47EC30", VA = "0x1047FE30")]
    private void ShowResult()
    {
    }

    [Token(Token = "0x600869B")]
    [Address(RVA = "0x47FDC0", Offset = "0x47EBC0", VA = "0x1047FDC0")]
    private IEnumerator ShowResultAsync() => (IEnumerator) null;

    [Token(Token = "0x600869C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AutoRepeatQuestResult()
    {
    }
  }
}
